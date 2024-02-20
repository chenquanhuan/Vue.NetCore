using Epoch.System.IRepositories;
using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Core.EFDbContext;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Repositories
{
    public partial class Sys_MenuRepository : RepositoryBase<Sys_Menu>, ISys_MenuRepository
    {
        public Sys_MenuRepository(EpochContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_MenuRepository Instance
        {
            get { return AutofacContainerModule.GetService<ISys_MenuRepository>(); }
        }
    }
}

