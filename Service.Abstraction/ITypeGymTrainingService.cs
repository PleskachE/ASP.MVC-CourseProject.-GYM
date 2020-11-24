using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ITypeGymTrainingService
    {
        void Add(TypeGymTraining typeGymTraining);

        void Remove(TypeGymTraining typeGymTraining);

        void Update(TypeGymTraining typeGymTraining);

        TypeGymTraining GetById(int id);

        IEnumerable<TypeGymTraining> GetTypeGymTrainings();
    }
}
