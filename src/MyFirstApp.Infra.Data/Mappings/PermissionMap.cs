using Microsoft.EntityFrameworkCore;
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

            builder.Property(g => g.ConstantName)       
                   .HasColumnType("varchar(30)")
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(g => g.Title)
                   .HasColumnType("varchar(50)")
                   .HasMaxLength(50)
                   .IsRequired();
        }
    }
}