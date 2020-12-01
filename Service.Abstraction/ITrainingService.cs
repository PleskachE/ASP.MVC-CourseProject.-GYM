using Data.Entity;

using System.Collections.Generic;

namespace Service.Abstraction
{
    public interface ITrainingService
    {
        void Add(Training training);

        void Remove(Training training);

        void Update(Training training);

        Training GetById(int id);

        IEnumerable<Training> GetTrainings();
    }
}
