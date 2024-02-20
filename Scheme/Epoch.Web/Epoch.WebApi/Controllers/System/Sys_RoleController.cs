﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Epoch.Core.Controllers.Basic;
using Epoch.Core.Enums;
using Epoch.Core.Filters;
using Epoch.Entity.AttributeManager;
using Epoch.Entity.DomainModels;
using Epoch.System.IServices;

namespace Epoch.System.Controllers
{
    [Route("api/Sys_Role")]
    [PermissionTable(Name = "Sys_Role")]
    public partial class Sys_RoleController : ApiBaseController<ISys_RoleService>
    {
        public Sys_RoleController(ISys_RoleService service)
        : base("System", "System", "Sys_Role", service)
        {

        }
    }
}


