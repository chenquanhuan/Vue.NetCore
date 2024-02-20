using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class Sys_WorkFlowMapConfig : EntityMappingConfiguration<Sys_WorkFlow>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlow>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

