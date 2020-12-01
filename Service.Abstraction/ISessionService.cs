using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ISessionService
    {
        void Add(Session sessions);

        void Remove(Session session);

        void Update(Session session);

        Session GetById(int id);

        IEnumerable<Session> GetSessions();
    }
}
