using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
