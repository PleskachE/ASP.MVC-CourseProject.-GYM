using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class RoleService : IRoleService
    {
        private readonly IDataUnitOfWork _uow;

        public RoleService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Role role)
        {
            _uow.RoleRepository.Create(role);
            _uow.Commit();
        }

        public Role GetById(int id)
        {
            return _uow.RoleRepository.GetById(id);
        }

        public IEnumerable<Role> GetRoles()
        {
            return _uow.RoleRepository.GetAll();
        }

        public void Remove(Role role)
        {
            _uow.RoleRepository.Remove(role);
            _uow.Commit();
        }

        public void Update(Role role)
        {
            _uow.RoleRepository.Update(role);
            _uow.Commit();
        }
    }
}
