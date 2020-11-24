using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class RolesRepository : Repository<Roles>, IRolesRepository
    {
        public RolesRepository(DbContext context) : base(context)
        {

        }
    }
}
