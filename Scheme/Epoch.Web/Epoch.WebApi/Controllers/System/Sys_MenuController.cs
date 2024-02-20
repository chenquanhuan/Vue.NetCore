using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Epoch.Core.Controllers.Basic;
using Epoch.Core.Enums;
using Epoch.Core.Filters;
using Epoch.Entity.DomainModels;
using Epoch.System.IServices;

namespace Epoch.System.Controllers
{
    [Route("api/menu")]
    [ApiController, JWTAuthorize()]
    public partial class Sys_MenuController : ApiBaseController<ISys_MenuService>
    {
        private ISys_MenuService _service { get; set; }
        public Sys_MenuController(ISys_MenuService service) :
            base("System", "System", "Sys_Menu", service)
        {
            _service = service;
        } 
    }
}
