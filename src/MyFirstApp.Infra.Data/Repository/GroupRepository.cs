using MyFirstApp.Domain.Models;
using MyFirstApp.Domain.Contracts.Repository;
using MyFirstApp.Infra.Data.Context;


namespace MyFirstApp.Infra.Data.Repository
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(MyFirstAppContext Context) : base(Context) {}
    
    }
}