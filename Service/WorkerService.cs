using Data.Abstractions;
using Data.Entity;
using Service.Abstraction;

using System.Collections.Generic;

namespace Service
{
    public class WorkerService : IWorkerService
    {
        private readonly IDataUnitOfWork _uow;

        public WorkerService(IDataUnitOfWork uow)
        {
            this._uow = uow;
        }

        public void Add(Worker worker)
        {
            _uow.WorkerRepository.Create(worker);
            _uow.Commit();
        }

        public Worker GetById(int id)
        {
            return _uow.WorkerRepository.GetById(id);
        }

        public IEnumerable<Worker> GetWorker()
        {
            return _uow.WorkerRepository.GetAll();
        }

        public void Remove(Worker worker)
        {
            _uow.WorkerRepository.Remove(worker);
            _uow.Commit();
        }

        public void Update(Worker worker)
        {
            _uow.WorkerRepository.Update(worker);
            _uow.Commit();
        }
    }
}
