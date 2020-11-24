using Base.Abstractions;
using Data.Abstractions.Repositories;

namespace Data.Abstractions
{
    public interface IDataUnitOfWork : IUnitOfWork
    {
        IClientRepository ClientRepository { get; }
        IRolesRepository RolesRepository { get; }
        ITrainingGymRepository TrainingGymRepository { get; }
        ITrainingRepository TrainingRepository { get; }
        ITrainingSessionsRepository TrainingSessionsRepository { get; }
        ITrainingSpecializationRepository TrainingSpecializationRepository { get; }
        ITypeGymTrainingRepository TypeGymTrainingRepository { get; }
        IWorkerRepository WorkerRepository { get; }
        IWorkSpecializationsRepository WorkSpecializationsRepository { get; }
    }
}
