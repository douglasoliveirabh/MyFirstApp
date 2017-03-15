using System;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace MyFirstApp.Test.Unit.Configuration
{
    public class TextFixtureBase : IDisposable
    {
        public readonly TestServer Server;
        public readonly HttpClient Client;
        public readonly DbContext TestDataContext;
        public readonly IConfigurationRoot Configuration;

        public TextFixtureBase()
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{envName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            /*
            var opts = new DbContextOptionsBuilder<DataContext>();
            opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            TestDataContext = new DataContext(opts.Options);
            SetupDatabase();
             

            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
            */
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}