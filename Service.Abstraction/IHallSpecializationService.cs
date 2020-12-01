using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IHallSpecializationService
    {
        void Add(HallSpecialization hallSpecialization);

        void Remove(HallSpecialization hallSpecialization);

        void Update(HallSpecialization hallSpecialization);

        HallSpecialization GetById(int id);

        IEnumerable<HallSpecialization> GetHallSpecializations();
    }
}
