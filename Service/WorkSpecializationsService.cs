using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class WorkSpecializationsService : IWorkSpecializationsService
    {
        private readonly IDataUnitOfWork _uow;

        public WorkSpecializationsService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(WorkSpecializations workSpecializations)
        {
            _uow.WorkSpecializationsRepository.Create(workSpecializations);
            _uow.Commit();
        }

        public WorkSpecializations GetById(int id)
        {
            return _uow.WorkSpecializationsRepository.GetById(id);
        }

        public IEnumerable<WorkSpecializations> GetWorkSpecializations()
        {
            return _uow.WorkSpecializationsRepository.GetAll();
        }

        public void Remove(WorkSpecializations workSpecializations)
        {
            _uow.WorkSpecializationsRepository.Remove(workSpecializations);
            _uow.Commit();
        }

        public void Update(WorkSpecializations workSpecializations)
        {
            _uow.WorkSpecializationsRepository.Update(workSpecializations);
            _uow.Commit();
        }
    }
}
