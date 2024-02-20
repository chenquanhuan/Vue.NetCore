using Epoch.System.IRepositories;
using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Core.EFDbContext;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Repositories
{
    public partial class Sys_LogRepository : RepositoryBase<Sys_Log>, ISys_LogRepository
    {
        public Sys_LogRepository(EpochContext dbContext)
        : base(dbContext)
        {

        }
        public static ISys_LogRepository GetService
        {
            get { return AutofacContainerModule.GetService<ISys_LogRepository>(); }
        }
    }
}

