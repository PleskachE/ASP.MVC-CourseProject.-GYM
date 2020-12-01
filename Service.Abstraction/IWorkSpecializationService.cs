using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IWorkSpecializationService
    {
        void Add(WorkSpecialization workSpecialization);

        void Remove(WorkSpecialization workSpecialization);

        void Update(WorkSpecialization workSpecialization);

        WorkSpecialization GetById(int id);

        IEnumerable<WorkSpecialization> GetWorkSpecializations();
    }
}
