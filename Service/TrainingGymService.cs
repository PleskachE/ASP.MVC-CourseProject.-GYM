using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class TrainingGymService : ITrainingGymService
    {
        private readonly IDataUnitOfWork _uow;

        public TrainingGymService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(TrainingGym trainingGym)
        {
            _uow.TrainingGymRepository.Create(trainingGym);
            _uow.Commit();
        }

        public TrainingGym GetById(int id)
        {
            return _uow.TrainingGymRepository.GetById(id);
        }

        public IEnumerable<TrainingGym> GetTrainingGyms()
        {
            return _uow.TrainingGymRepository.GetAll();
        }

        public void Remove(TrainingGym trainingGym)
        {
            _uow.TrainingGymRepository.Remove(trainingGym);
            _uow.Commit();
        }

        public void Update(TrainingGym trainingGym)
        {
            _uow.TrainingGymRepository.Update(trainingGym);
            _uow.Commit();
        }
    }
}
