using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class SessionRepository : Repository<Session>, ISessionRepository
    {
        public SessionRepository(DbContext context) : base(context)
        {

        }
    }
}
