using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class TrainingSessionsRepository : Repository<TrainingSessions>, ITrainingSessionsRepository
    {
        public TrainingSessionsRepository(DbContext context) : base(context)
        {

        }
    }
}
