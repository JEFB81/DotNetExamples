using System.Threading.Tasks;

namespace PollyExample
{
    public interface IGitHubSearchAccountPublicInfo
    {
        Task<UserInfo> LoadAccount(string accountName);
    }
}
