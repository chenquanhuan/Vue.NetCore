﻿/*
 *Author：jxx
 *Contact：283591387@qq.com
 *Date：2018-07-01
 * 此代码由框架生成，请勿随意更改
 */
using Epoch.System.IRepositories;
using Epoch.Core.BaseProvider;
using Epoch.Core.EFDbContext;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Repositories
{
    public partial class Sys_RoleRepository : RepositoryBase<Sys_Role>, ISys_RoleRepository
    {
        public Sys_RoleRepository(EpochContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_RoleRepository Instance
        {
            get { return AutofacContainerModule.GetService<ISys_RoleRepository>(); }
        }
    }
}

