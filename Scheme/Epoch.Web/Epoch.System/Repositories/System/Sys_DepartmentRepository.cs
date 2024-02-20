/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Sys_DepartmentRepository编写代码
 */
using Epoch.System.IRepositories;
using Epoch.Core.BaseProvider;
using Epoch.Core.EFDbContext;
using Epoch.Core.Extensions.AutofacManager;
using Epoch.Entity.DomainModels;

namespace Epoch.System.Repositories
{
    public partial class Sys_DepartmentRepository : RepositoryBase<Sys_Department> , ISys_DepartmentRepository
    {
    public Sys_DepartmentRepository(EpochContext dbContext)
    : base(dbContext)
    {

    }
    public static ISys_DepartmentRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ISys_DepartmentRepository>(); } }
    }
}
