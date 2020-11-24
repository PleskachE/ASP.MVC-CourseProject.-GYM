using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ITrainingSpecializationService
    {
        void Add(TrainingSpecialization trainingSpecialization);

        void Remove(TrainingSpecialization trainingSpecialization);

        void Update(TrainingSpecialization trainingSpecialization);

        TrainingSpecialization GetById(int id);

        IEnumerable<TrainingSpecialization> GetTrainingSpecializations();
    }
}
