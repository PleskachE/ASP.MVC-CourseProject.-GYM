using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(DbContext context) : base(context)
        {

        }
    }
}
