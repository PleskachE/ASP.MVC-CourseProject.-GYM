using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class HallRepository : Repository<Hall>, IHallRepository
    {
        public HallRepository(DbContext context) : base(context)
        {

        }
    }
}
