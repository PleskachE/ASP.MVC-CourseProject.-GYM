using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class HallService : IHallService
    {
        private readonly IDataUnitOfWork _uow;

        public HallService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Hall hall)
        {
            _uow.HallRepository.Create(hall);
            _uow.Commit();
        }

        public Hall GetById(int id)
        {
            return _uow.HallRepository.GetById(id);
        }

        public IEnumerable<Hall> GetHalls()
        {
            return _uow.HallRepository.GetAll();
        }

        public void Remove(Hall hall)
        {
            _uow.HallRepository.Remove(hall);
            _uow.Commit();
        }

        public void Update(Hall hall)
        {
            _uow.HallRepository.Update(hall);
            _uow.Commit();
        }
    }
}
