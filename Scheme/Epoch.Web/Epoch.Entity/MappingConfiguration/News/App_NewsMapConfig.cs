using Epoch.Entity.MappingConfiguration;
using Epoch.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epoch.Entity.MappingConfiguration
{
    public class App_NewsMapConfig : EntityMappingConfiguration<App_News>
    {
        public override void Map(EntityTypeBuilder<App_News>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

