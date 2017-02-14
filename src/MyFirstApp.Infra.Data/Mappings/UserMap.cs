using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApp.Domain.Models;
using MyFirstApp.Infra.Data.Extensions;


namespace MyFirstApp.Infra.Data.Mappings
{    
    public class UserMap : EntityTypeConfiguration<User>
    {
        public override void Map(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.HasMany(u => u.Groups); 

            builder.Property(u => u.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(u => u.Username)       
                    .HasColumnType("varchar(20)")
                    .HasMaxLength(20)
                    .IsRequired(); 

            builder.Property(u => u.Password)       
                    .HasColumnType("varchar(20)")
                    .HasMaxLength(20)
                    .IsRequired(); 
        }
    }
}