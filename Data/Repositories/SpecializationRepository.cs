using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;


namespace Data.Repositories
{
    internal class SpecializationRepository : Repository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(DbContext context) : base(context)
        {

        }
    }
}
