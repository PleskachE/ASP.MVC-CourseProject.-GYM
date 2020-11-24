using Base.Abstractions;
using Data.Entity;

namespace Data.Abstractions.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        void Create(Client client);
    }
}
