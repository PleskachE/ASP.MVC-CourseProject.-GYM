using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class TrainingService : ITrainingService
    {
        private readonly IDataUnitOfWork _uow;

        public TrainingService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Training training)
        {
            _uow.TrainingRepository.Create(training);
            _uow.Commit();
        }

        public Training GetById(int id)
        {
            return _uow.TrainingRepository.GetById(id);
        }

        public IEnumerable<Training> GetTrainings()
        {
            return _uow.TrainingRepository.GetAll();
        }

        public void Remove(Training training)
        {
            _uow.TrainingRepository.Remove(training);
            _uow.Commit();
        }

        public void Update(Training training)
        {
            _uow.TrainingRepository.Update(training);
            _uow.Commit();
        }
    }
}
