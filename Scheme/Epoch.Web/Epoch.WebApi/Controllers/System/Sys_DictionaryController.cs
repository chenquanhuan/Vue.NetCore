using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Epoch.Core.Controllers.Basic;
using Epoch.Core.Extensions;
using Epoch.Core.Filters;
using Epoch.System.IServices;

namespace Epoch.System.Controllers
{
    [Route("api/Sys_Dictionary")]
    public partial class Sys_DictionaryController : ApiBaseController<ISys_DictionaryService>
    {
        public Sys_DictionaryController(ISys_DictionaryService service)
        : base("System", "System", "Sys_Dictionary", service)
        {
        }
    }
}
