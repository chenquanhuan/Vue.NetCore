/*
 *Author：jxx
 *Contact：283591387@qq.com
 *Date：2018-07-01
 * 此代码由框架生成，请勿随意更改
 */
using Epoch.System.IRepositories;
using Epoch.System.IServices;
using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Services
{
    public partial class Sys_RoleService : ServiceBase<Sys_Role, ISys_RoleRepository>, ISys_RoleService, IDependency
    {
        public Sys_RoleService(ISys_RoleRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_RoleService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_RoleService>(); }
        }
    }
}

