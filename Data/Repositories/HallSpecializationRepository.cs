using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class HallSpecializationRepository : Repository<HallSpecialization>, IHallSpecializationRepository
    {
        public HallSpecializationRepository(DbContext context) : base(context)
        {

        }
    }
}
