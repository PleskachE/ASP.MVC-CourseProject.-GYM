using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class WorkSpecializationRepository : Repository<WorkSpecialization>, IWorkSpecializationRepository
    {
        public WorkSpecializationRepository(DbContext context) : base(context)
        {

        }
    }
}
