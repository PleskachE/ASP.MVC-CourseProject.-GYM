using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class TrainingSessionsService : ITrainingSessionsService
    {

        private readonly IDataUnitOfWork _uow;

        public TrainingSessionsService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(TrainingSessions trainingSessions)
        {
            _uow.TrainingSessionsRepository.Create(trainingSessions);
            _uow.Commit();
        }

        public TrainingSessions GetById(int id)
        {
            return _uow.TrainingSessionsRepository.GetById(id);
        }

        public IEnumerable<TrainingSessions> GetTrainingSessions()
        {
            return _uow.TrainingSessionsRepository.GetAll();
        }

        public void Remove(TrainingSessions trainingSessions)
        {
            _uow.TrainingSessionsRepository.Remove(trainingSessions);
            _uow.Commit();
        }

        public void Update(TrainingSessions trainingSessions)
        {
            _uow.TrainingSessionsRepository.Update(trainingSessions);
            _uow.Commit();
        }
    }
}
