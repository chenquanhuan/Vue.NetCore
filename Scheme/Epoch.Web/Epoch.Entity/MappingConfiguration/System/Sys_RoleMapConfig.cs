using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Framework.Entity.MappingConfiguration
{
    public class Sys_RoleMapConfig : EntityMappingConfiguration<Sys_Role>
    {
        public override void Map(EntityTypeBuilder<Sys_Role> builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
    }
}


