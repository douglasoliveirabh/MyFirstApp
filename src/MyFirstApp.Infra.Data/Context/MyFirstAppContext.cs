using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyFirstApp.Infra.Data.Mappings;
using MyFirstApp.Infra.Data.Extensions;

namespace MyFirstApp.Infra.Data.Context
{
    public class MyFirstAppContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new UserMap());
            modelBuilder.AddConfiguration(new GroupMap());
            modelBuilder.AddConfiguration(new PermissionMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlite("Filename=./MyFirstApp.db");            
           
        } 
        
    }

}