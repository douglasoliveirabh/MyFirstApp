using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApp.Domain.Models;
using MyFirstApp.Infra.Data.Extensions;


namespace MyFirstApp.Infra.Data.Mappings
{    
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public override void Map(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.GroupId);                
            builder.HasMany(g => g.Users);
            builder.HasMany(g => g.Permissions);       

             builder.Property(g => g.Name)       
                    .HasColumnType("varchar(30)")
                    .HasMaxLength(30)
                    .IsRequired();     
        }
    }
}