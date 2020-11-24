using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class TypeGymTrainingService : ITypeGymTrainingService
    {
        private readonly IDataUnitOfWork _uow;

        public TypeGymTrainingService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(TypeGymTraining typeGymTraining)
        {
            _uow.TypeGymTrainingRepository.Create(typeGymTraining);
            _uow.Commit();
        }

        public TypeGymTraining GetById(int id)
        {
            return _uow.TypeGymTrainingRepository.GetById(id);
        }

        public IEnumerable<TypeGymTraining> GetTypeGymTrainings()
        {
            return _uow.TypeGymTrainingRepository.GetAll();
        }

        public void Remove(TypeGymTraining typeGymTraining)
        {
            _uow.TypeGymTrainingRepository.Remove(typeGymTraining);
            _uow.Commit();
        }

        public void Update(TypeGymTraining typeGymTraining)
        {
            _uow.TypeGymTrainingRepository.Update(typeGymTraining);
            _uow.Commit();
        }
    }
}
