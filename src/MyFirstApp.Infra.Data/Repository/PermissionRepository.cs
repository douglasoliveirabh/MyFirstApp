using MyFirstApp.Domain.Models;
using MyFirstApp.Domain.Contracts.Repository;
using MyFirstApp.Infra.Data.Context;


namespace MyFirstApp.Infra.Data.Repository
{
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(MyFirstAppContext Context) : base(Context) {}

        

    }
}