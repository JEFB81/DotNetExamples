using Polly;
using Polly.Retry;
using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PollyExample
{
    public class GitHubSearchAccountPublicInfo : IGitHubSearchAccountPublicInfo
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly AsyncRetryPolicy _retryPolicy;
        private readonly Random Random = new Random();

        private int MaxRetries = 3;

        public GitHubSearchAccountPublicInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _retryPolicy = Policy.Handle<HttpRequestException>(
            //    exception =>
            //{
            //    //return exception.Message != "Fake exception";
            //    // retry time each incrementing the waiting period by 100 milliseconds
            //}
            ).WaitAndRetryAsync(MaxRetries, times => TimeSpan.FromMilliseconds(times * 100));
        }

        public async Task<UserInfo> LoadAccount(string accountName) 
        {
            var httpClient = _httpClientFactory.CreateClient("GitHub");

            var httpResponseMessage = await httpClient.GetAsync($"users/{accountName}");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<UserInfo>(contentStream);
            }

            return new UserInfo();
        }
        /// <summary>
        /// Added properties AsyncRetryPolicy to use Polly different
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public async Task<UserInfo> LoadAccountWithRetry(string accountName) 
        {
            var httpClient = _httpClientFactory.CreateClient("GitHub");

            await _retryPolicy.ExecuteAsync(async () => 
            {
                if (Random.Next(1, 3) == 1)
                {
                    throw new HttpRequestException("Fake exception");
                }

                var httpResponseMessage = await httpClient.GetAsync($"users/{accountName}");

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    using var contentStream =
                        await httpResponseMessage.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<UserInfo>(contentStream);
                }
                if (httpResponseMessage.StatusCode.Equals(HttpStatusCode.NotFound)) 
                {
                    using var contentStream =
                       await httpResponseMessage.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<UserInfo>(contentStream);
                }
                // we've no match
                return new UserInfo();

            });

            return new UserInfo();

        }

    }
}
