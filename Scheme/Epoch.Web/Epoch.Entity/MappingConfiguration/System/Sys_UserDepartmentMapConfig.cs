using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class Sys_UserDepartmentMapConfig : EntityMappingConfiguration<Sys_UserDepartment>
    {
        public override void Map(EntityTypeBuilder<Sys_UserDepartment>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

