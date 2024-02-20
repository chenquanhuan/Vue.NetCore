using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class Sys_QuartzOptionsMapConfig : EntityMappingConfiguration<Sys_QuartzOptions>
    {
        public override void Map(EntityTypeBuilder<Sys_QuartzOptions>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

