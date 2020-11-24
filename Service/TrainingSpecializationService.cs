using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class TrainingSpecializationService : ITrainingSpecializationService
    {
        private readonly IDataUnitOfWork _uow;

        public TrainingSpecializationService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(TrainingSpecialization trainingSpecialization)
        {
            _uow.TrainingSpecializationRepository.Create(trainingSpecialization);
            _uow.Commit();
        }

        public TrainingSpecialization GetById(int id)
        {
            return _uow.TrainingSpecializationRepository.GetById(id);
        }

        public IEnumerable<TrainingSpecialization> GetTrainingSpecializations()
        {
            return _uow.TrainingSpecializationRepository.GetAll();
        }

        public void Remove(TrainingSpecialization trainingSpecialization)
        {
            _uow.TrainingSpecializationRepository.Remove(trainingSpecialization);
            _uow.Commit();
        }

        public void Update(TrainingSpecialization trainingSpecialization)
        {
            _uow.TrainingSpecializationRepository.Update(trainingSpecialization);
            _uow.Commit();
        }
    }
}
