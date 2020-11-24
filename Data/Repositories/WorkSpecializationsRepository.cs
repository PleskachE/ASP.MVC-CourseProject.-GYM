using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class WorkSpecializationsRepository : Repository<WorkSpecializations>, IWorkSpecializationsRepository
    {
        public WorkSpecializationsRepository(DbContext context) : base(context)
        {

        }
    }
}
