using Data.Abstractions.Repositories;
using Data.Entity;

using System.Data.Entity;

namespace Data.Repositories
{
    internal class TypeGymTrainingRepository : Repository<TypeGymTraining>, ITypeGymTrainingRepository
    {
        public TypeGymTrainingRepository(DbContext context) : base(context)
        {

        }
    }
}
