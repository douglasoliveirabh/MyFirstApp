using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyFirstApp.Infra.Data.Mappings;
using MyFirstApp.Infra.Data.Extensions;
using MyFirstApp.Domain.Models;
using System;

namespace MyFirstApp.Infra.Data.Context
{
    public class MyFirstAppContext : DbContext
    {

        public MyFirstAppContext() : base()
        {
            
        }

        public MyFirstAppContext(DbContextOptions<MyFirstAppContext> options) : base(options)
        {            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new UserMap());
            modelBuilder.AddConfiguration(new GroupMap());
            modelBuilder.AddConfiguration(new PermissionMap());
            modelBuilder.AddConfiguration(new UserGroupMap());
            modelBuilder.AddConfiguration(new GroupPermissionMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                    
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));            
           
        } 
        
    }

}