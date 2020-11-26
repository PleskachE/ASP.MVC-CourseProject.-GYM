using Base.Abstractions;
using Data.Abstractions.Repositories;

namespace Data.Abstractions
{
    public interface IDataUnitOfWork : IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IRolesRepository RolesRepository { get; }
        ITrainingGymRepository TrainingGymRepository { get; }
        ITrainingRepository TrainingRepository { get; }
        ITrainingSessionsRepository TrainingSessionsRepository { get; }
        ITrainingSpecializationRepository TrainingSpecializationRepository { get; }
        ITypeGymTrainingRepository TypeGymTrainingRepository { get; }
        IWorkSpecializationsRepository WorkSpecializationsRepository { get; }
    }
}
