using Base.Abstractions;
using Data.Abstractions.Repositories;

namespace Data.Abstractions
{
    public interface IDataUnitOfWork : IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IHallRepository HallRepository { get; }
        ITrainingRepository TrainingRepository { get; }
        ISessionRepository SessionRepository { get; }
        ISpecializationRepository SpecializationRepository { get; }
        IHallSpecializationRepository HallSpecializationRepository { get; }
        IWorkSpecializationRepository WorkSpecializationsRepository { get; }
    }
}
