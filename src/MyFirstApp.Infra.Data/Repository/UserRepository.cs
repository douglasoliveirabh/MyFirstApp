using MyFirstApp.Domain.Models;
using MyFirstApp.Domain.Contracts.Repository;
using MyFirstApp.Infra.Data.Context;


namespace MyFirstApp.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(MyFirstAppContext Context) : base(Context) {}
    
    }
}