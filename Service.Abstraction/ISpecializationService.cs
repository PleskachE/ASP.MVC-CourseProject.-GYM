using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ISpecializationService
    {
        void Add(Specialization specialization);

        void Remove(Specialization specialization);

        void Update(Specialization specialization);

        Specialization GetById(int id);

        IEnumerable<Specialization> GetSpecializations();
    }
}
