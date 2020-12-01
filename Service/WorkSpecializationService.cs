using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class WorkSpecializationService : IWorkSpecializationService
    {
        private readonly IDataUnitOfWork _uow;

        public WorkSpecializationService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(WorkSpecialization workSpecialization)
        {
            _uow.WorkSpecializationsRepository.Create(workSpecialization);
            _uow.Commit();
        }

        public WorkSpecialization GetById(int id)
        {
            return _uow.WorkSpecializationsRepository.GetById(id);
        }

        public IEnumerable<WorkSpecialization> GetWorkSpecializations()
        {
            return _uow.WorkSpecializationsRepository.GetAll();
        }

        public void Remove(WorkSpecialization workSpecialization)
        {
            _uow.WorkSpecializationsRepository.Remove(workSpecialization);
            _uow.Commit();
        }

        public void Update(WorkSpecialization workSpecialization)
        {
            _uow.WorkSpecializationsRepository.Update(workSpecialization);
            _uow.Commit();
        }
    }
}
