using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class TrainingRepository : Repository<Training>, ITrainingRepository
    {
        public TrainingRepository(DbContext context) : base(context)
        {

        }
    }
}
