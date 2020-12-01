using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IRoleService
    {
        void Add(Role role);

        void Remove(Role role);

        void Update(Role role);

        Role GetById(int id);

        IEnumerable<Role> GetRoles();
    }
}
