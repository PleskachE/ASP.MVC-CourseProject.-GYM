using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {

        }
    }
}
