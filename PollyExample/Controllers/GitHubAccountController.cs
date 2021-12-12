using Microsoft.AspNetCore.Mvc;
//https://www.youtube.com/watch?v=9pgvX_Dk0n8&t=458s
namespace PollyExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubAccountController : Controller
    {
        private IGitHubSearchAccountPublicInfo _gitHubSearchAccountPublicInfo;

        public GitHubAccountController(IGitHubSearchAccountPublicInfo gitHubSearchAccountPublicInfo )
        {
            _gitHubSearchAccountPublicInfo = gitHubSearchAccountPublicInfo;
        }

        [HttpGet]
        public ActionResult<UserInfo> Get(string AccountInfo)
        {
            if (string.IsNullOrEmpty(AccountInfo)) 
            {
                AccountInfo = "defunkt";
            };

            var result = _gitHubSearchAccountPublicInfo.LoadAccount(AccountInfo).GetAwaiter().GetResult();

            return Ok(result);
        }
    }
}
