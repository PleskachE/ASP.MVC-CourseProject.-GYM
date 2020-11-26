using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class UserService : IUserService
    {

        private readonly IDataUnitOfWork _uow;

        public UserService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(User user)
        {
            _uow.UserRepository.Create(user);
            _uow.Commit();
        }

        public User GetById(int id)
        {
            return _uow.UserRepository.GetById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _uow.UserRepository.GetAll();
        }

        public void Remove(User user)
        {
            _uow.UserRepository.Remove(user);
            _uow.Commit();
        }

        public void Update(User user)
        {
            _uow.UserRepository.Update(user);
            _uow.Commit();
        }
    }
}
