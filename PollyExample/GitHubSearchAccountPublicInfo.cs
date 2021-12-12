using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PollyExample
{
    public class GitHubSearchAccountPublicInfo : IGitHubSearchAccountPublicInfo
    {
        private readonly IHttpClientFactory _httpClientFactory; 

        public GitHubSearchAccountPublicInfo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
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
         
    }
}
