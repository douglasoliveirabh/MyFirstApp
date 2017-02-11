using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApp.Domain.Models;
using MyFirstApp.Infra.Data.Extensions;


namespace MyFirstApp.Infra.Data.Mappings
{    
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public override void Map(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(g => g.PermissionId);                
            builder.HasMany(g => g.Groups);        
        }
    }
}