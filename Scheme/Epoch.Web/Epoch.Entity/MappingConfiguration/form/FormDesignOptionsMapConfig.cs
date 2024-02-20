using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class FormDesignOptionsMapConfig : EntityMappingConfiguration<FormDesignOptions>
    {
        public override void Map(EntityTypeBuilder<FormDesignOptions>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

