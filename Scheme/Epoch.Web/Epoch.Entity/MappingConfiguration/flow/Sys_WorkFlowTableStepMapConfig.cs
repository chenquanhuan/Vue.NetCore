using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class Sys_WorkFlowTableStepMapConfig : EntityMappingConfiguration<Sys_WorkFlowTableStep>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowTableStep>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

