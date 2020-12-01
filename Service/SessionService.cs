using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class SessionService : ISessionService
    {

        private readonly IDataUnitOfWork _uow;

        public SessionService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Session session)
        {
            _uow.SessionRepository.Create(session);
            _uow.Commit();
        }

        public Session GetById(int id)
        {
            return _uow.SessionRepository.GetById(id);
        }

        public IEnumerable<Session> GetSessions()
        {
            return _uow.SessionRepository.GetAll();
        }

        public void Remove(Session session)
        {
            _uow.SessionRepository.Remove(session);
            _uow.Commit();
        }

        public void Update(Session session)
        {
            _uow.SessionRepository.Update(session);
            _uow.Commit();
        }
    }
}
