using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class HallSpecializationService : IHallSpecializationService
    {
        private readonly IDataUnitOfWork _uow;

        public HallSpecializationService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(HallSpecialization hallSpecialization)
        {
            _uow.HallSpecializationRepository.Create(hallSpecialization);
            _uow.Commit();
        }

        public HallSpecialization GetById(int id)
        {
            return _uow.HallSpecializationRepository.GetById(id);
        }

        public IEnumerable<HallSpecialization> GetHallSpecializations()
        {
            return _uow.HallSpecializationRepository.GetAll();
        }

        public void Remove(HallSpecialization hallSpecialization)
        {
            _uow.HallSpecializationRepository.Remove(hallSpecialization);
            _uow.Commit();
        }

        public void Update(HallSpecialization hallSpecialization)
        {
            _uow.HallSpecializationRepository.Update(hallSpecialization);
            _uow.Commit();
        }
    }
}
