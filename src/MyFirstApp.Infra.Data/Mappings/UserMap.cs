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
        }
    }
}