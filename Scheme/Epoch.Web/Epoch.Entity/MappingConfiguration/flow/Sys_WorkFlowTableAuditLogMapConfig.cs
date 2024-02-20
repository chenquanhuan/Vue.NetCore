using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class Sys_WorkFlowTableAuditLogMapConfig : EntityMappingConfiguration<Sys_WorkFlowTableAuditLog>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowTableAuditLog>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

