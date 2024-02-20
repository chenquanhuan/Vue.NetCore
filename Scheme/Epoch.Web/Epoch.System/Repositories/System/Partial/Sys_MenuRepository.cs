using Epoch.System.IRepositories;
using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Core.EFDbContext;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Repositories
{
    public partial class Sys_MenuRepository
    {
        public override EpochContext DbContext => base.DbContext;
    }
}

