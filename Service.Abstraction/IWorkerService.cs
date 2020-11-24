using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IWorkerService
    {
        void Add(Worker worker);

        void Remove(Worker worker);

        void Update(Worker worker);

        Worker GetById(int id);

        IEnumerable<Worker> GetWorker();
    }
}
