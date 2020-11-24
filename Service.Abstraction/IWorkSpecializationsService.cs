using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface IWorkSpecializationsService
    {
        void Add(WorkSpecializations workSpecializations);

        void Remove(WorkSpecializations workSpecializations);

        void Update(WorkSpecializations workSpecializations);

        WorkSpecializations GetById(int id);

        IEnumerable<WorkSpecializations> GetWorkSpecializations();
    }
}
