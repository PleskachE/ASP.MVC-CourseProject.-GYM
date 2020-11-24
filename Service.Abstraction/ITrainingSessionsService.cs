using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ITrainingSessionsService
    {
        void Add(TrainingSessions trainingSessions);

        void Remove(TrainingSessions trainingSessions);

        void Update(TrainingSessions trainingSessions);

        TrainingSessions GetById(int id);

        IEnumerable<TrainingSessions> GetTrainingSessions();
    }
}
