using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;


namespace Data.Repositories
{
    internal class TrainingSpecializationRepository : Repository<TrainingSpecialization>, ITrainingSpecializationRepository
    {
        public TrainingSpecializationRepository(DbContext context) : base(context)
        {

        }
    }
}
