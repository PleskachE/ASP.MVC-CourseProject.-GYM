using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class SpecializationService : ISpecializationService
    {
        private readonly IDataUnitOfWork _uow;

        public SpecializationService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Specialization specialization)
        {
            _uow.SpecializationRepository.Create(specialization);
            _uow.Commit();
        }

        public Specialization GetById(int id)
        {
            return _uow.SpecializationRepository.GetById(id);
        }

        public IEnumerable<Specialization> GetSpecializations()
        {
            return _uow.SpecializationRepository.GetAll();
        }

        public void Remove(Specialization specialization)
        {
            _uow.SpecializationRepository.Remove(specialization);
            _uow.Commit();
        }

        public void Update(Specialization specialization)
        {
            _uow.SpecializationRepository.Update(specialization);
            _uow.Commit();
        }
    }
}
