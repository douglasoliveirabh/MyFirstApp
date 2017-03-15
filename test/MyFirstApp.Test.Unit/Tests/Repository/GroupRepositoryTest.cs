using Microsoft.EntityFrameworkCore;
using MyFirstApp.Domain.Models;
using MyFirstApp.Infra.Data.Context;
using MyFirstApp.Infra.Data.Repository;
using Xunit;
using System.Linq;
using System;

namespace MyFirstApp.Test.Unit.Tests.Repository
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html    
    public class GroupRepositoryTest
    {
        private GroupRepository Repository;

        public GroupRepositoryTest()
        {
            // In memory doesn't work with migrations
            // We can't use in memory database with migrations
            var options = new DbContextOptionsBuilder<MyFirstAppContext>()
                .UseInMemoryDatabase(databaseName: "MyFirstAppDatabaseTest")
                .Options;

            var context = new MyFirstAppContext(); //new MyFirstAppContext(options);
            context.Database.Migrate();

            this.Repository = new GroupRepository(context);
        }

        [Fact]
        public void Should_Add_Group()
        {

            this.Repository.Add(new Group("Douglas"));
            this.Repository.Commit();

            var groups = this.Repository.GetAll().ToList();

            Console.WriteLine("number of groups: " + groups.Count().ToString());

            Assert.Equal(groups.Count(), 1);

        }

        /*
                [Fact]
                public void PassingTest()
                {
                    Assert.Equal(4, Add(2, 2));
                }

                [Fact]
                public void FailingTest()
                {
                    Assert.Equal(5, Add(2, 2));
                }

                int Add(int x, int y)
                {
                    return x + y;
                }
                 */
    }

}