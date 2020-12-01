using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IHallService
    {
        void Add(Hall hall);

        void Remove(Hall hall);

        void Update(Hall hall);

        Hall GetById(int id);

        IEnumerable<Hall> GetHalls();
    }
}
