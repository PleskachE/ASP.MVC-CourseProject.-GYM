using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class ClientService : IClientService
    {

        private readonly IDataUnitOfWork _uow;

        public ClientService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Client client)
        {
            _uow.ClientRepository.Create(client);
            _uow.Commit();
        }

        public Client GetById(int id)
        {
            return _uow.ClientRepository.GetById(id);
        }

        public IEnumerable<Client> GetClients()
        {
            return _uow.ClientRepository.GetAll();
        }

        public void Remove(Client client)
        {
            _uow.ClientRepository.Remove(client);
            _uow.Commit();
        }

        public void Update(Client client)
        {
            _uow.ClientRepository.Update(client);
            _uow.Commit();
        }
    }
}
