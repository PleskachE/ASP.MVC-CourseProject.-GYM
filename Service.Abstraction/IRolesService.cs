using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IRolesService
    {
        void Add(Roles roles);

        void Remove(Roles roles);

        void Update(Roles roles);

        Roles GetById(int id);

        IEnumerable<Roles> GetRoles();
    }
}
