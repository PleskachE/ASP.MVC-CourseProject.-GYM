using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IClientService
    {
        void Add(Client client);

        void Remove(Client client);

        void Update(Client client);

        Client GetById(int id);

        IEnumerable<Client> GetClients();
    }
}
