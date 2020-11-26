using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IUserService
    {
        void Add(User user);

        void Remove(User user);

        void Update(User user);

        User GetById(int id);

        IEnumerable<User> GetUsers();
    }
}
