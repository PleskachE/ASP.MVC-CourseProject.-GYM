using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ITrainingGymService
    {
        void Add(TrainingGym trainingGym);

        void Remove(TrainingGym trainingGym);

        void Update(TrainingGym trainingGym);

        TrainingGym GetById(int id);

        IEnumerable<TrainingGym> GetTrainingGyms();
    }
}
