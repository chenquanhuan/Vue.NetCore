using Epoch.Core.BaseProvider;
using Epoch.Core.Utilities;
using Epoch.Entity.DomainModels;
using System.Threading.Tasks;

namespace Epoch.System.IServices
{
    public partial interface ISys_UserService
    {

        Task<WebResponseContent> Login(LoginInfo loginInfo, bool verificationCode = true);
        Task<WebResponseContent> ReplaceToken();
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd);
        Task<WebResponseContent> GetCurrentUserInfo();
    }
}

