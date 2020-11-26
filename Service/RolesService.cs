using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class RolesService : IRolesService
    {
        private readonly IDataUnitOfWork _uow;

        public RolesService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Roles roles)
        {
            _uow.RolesRepository.Create(roles);
            _uow.Commit();
        }

        public Roles GetById(int id)
        {
            return _uow.RolesRepository.GetById(id);
        }

        public IEnumerable<Roles> GetRoles()
        {
            return _uow.RolesRepository.GetAll();
        }

        public void Remove(Roles roles)
        {
            _uow.RolesRepository.Remove(roles);
            _uow.Commit();
        }

        public void Update(Roles roles)
        {
            _uow.RolesRepository.Update(roles);
            _uow.Commit();
        }
    }
}
