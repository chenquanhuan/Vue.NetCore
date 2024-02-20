using Epoch.System.IRepositories;
using Epoch.System.IServices;
using Epoch.Core.BaseProvider;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Services
{
    public partial class Sys_LogService : ServiceBase<Sys_Log, ISys_LogRepository>, ISys_LogService, IDependency
    {
        public Sys_LogService(ISys_LogRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_LogService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_LogService>(); }
        }
    }
}

