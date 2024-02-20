using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epoch.Core.BaseProvider;
using Epoch.Entity.DomainModels;
using Epoch.Core.Extensions.AutofacManager;
namespace Epoch.System.IRepositories
{
    public partial interface ISys_MenuRepository : IDependency,IRepository<Sys_Menu>
    {
    }
}

