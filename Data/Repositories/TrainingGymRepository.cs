using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class TrainingGymRepository : Repository<TrainingGym>, ITrainingGymRepository
    {
        public TrainingGymRepository(DbContext context) : base(context)
        {

        }
    }
}
