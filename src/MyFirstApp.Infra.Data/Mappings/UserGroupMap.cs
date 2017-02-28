using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApp.Domain.Models;
using MyFirstApp.Infra.Data.Extensions;


namespace MyFirstApp.Infra.Data.Mappings
{
    public class UserGroupMap : EntityTypeConfiguration<UserGroup>
    {
        public override void Map(EntityTypeBuilder<UserGroup> builder)
        {
            builder.ToTable("UserGroup");

            builder
                .HasKey(ug => new { ug.GroupId, ug.UserId });

            builder
                .HasOne(ug => ug.User)
                .WithMany(u => u.Groups)
                .HasForeignKey(ug => ug.UserId);

            builder
                .HasOne(ug => ug.Group)
                .WithMany(g => g.Users)
                .HasForeignKey(ug => ug.GroupId);


        }
    }
}