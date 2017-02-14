using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyFirstApp.Infra.Data.Context;

namespace MyFirstApp.Infra.Data.Migrations
{
    [DbContext(typeof(MyFirstAppContext))]
    partial class MyFirstAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirstApp.Domain.Models.Group", b =>
                {
                    b.Property<long>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<long?>("PermissionId");

                    b.Property<long?>("UserId");

                    b.HasKey("GroupId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MyFirstApp.Domain.Models.Permission", b =>
                {
                    b.Property<long>("PermissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConstantName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<long?>("GroupId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("PermissionId");

                    b.HasIndex("GroupId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("MyFirstApp.Domain.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<long?>("GroupId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UserId");

                    b.HasIndex("GroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyFirstApp.Domain.Models.Group", b =>
                {
                    b.HasOne("MyFirstApp.Domain.Models.Permission")
                        .WithMany("Groups")
                        .HasForeignKey("PermissionId");

                    b.HasOne("MyFirstApp.Domain.Models.User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MyFirstApp.Domain.Models.Permission", b =>
                {
                    b.HasOne("MyFirstApp.Domain.Models.Group")
                        .WithMany("Permissions")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("MyFirstApp.Domain.Models.User", b =>
                {
                    b.HasOne("MyFirstApp.Domain.Models.Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId");
                });
        }
    }
}
