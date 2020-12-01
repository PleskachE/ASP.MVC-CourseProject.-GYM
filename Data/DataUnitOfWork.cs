using Data.Abstractions;
using Data.Abstractions.Repositories;
using Data.Repositories;

namespace Data
{
    public class DataUnitOfWork: IDataUnitOfWork
    {
        private readonly DataDbContext _context;

        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IHallRepository _hallRepository;
        private ITrainingRepository _trainingRepository;
        private ISessionRepository _sessionRepository;
        private ISpecializationRepository _specializationRepository;
        private IHallSpecializationRepository _hallSpecializationRepository;
        private IWorkSpecializationRepository _workSpecializationRepository;

        public DataUnitOfWork(string connectionString)
        {
            _context = new DataDbContext(connectionString);
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }

                return _userRepository;
            }
        }

        public IRoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                {
                    _roleRepository = new RoleRepository(_context);
                }

                return _roleRepository;
            }
        }

        public IHallRepository HallRepository
        {
            get
            {
                if (_hallRepository == null)
                {
                    _hallRepository = new HallRepository(_context);
                }

                return _hallRepository;
            }
        }

        public ITrainingRepository TrainingRepository
        {
            get
            {
                if (_trainingRepository == null)
                {
                    _trainingRepository = new TrainingRepository(_context);
                }

                return _trainingRepository;
            }
        }

        public ISessionRepository SessionRepository
        {
            get
            {
                if (_sessionRepository == null)
                {
                    _sessionRepository = new SessionRepository(_context);
                }

                return _sessionRepository;
            }
        }

        public ISpecializationRepository SpecializationRepository
        {
            get
            {
                if (_specializationRepository == null)
                {
                    _specializationRepository = new SpecializationRepository(_context);
                }

                return _specializationRepository;
            }
        }

        public IHallSpecializationRepository HallSpecializationRepository
        {
            get
            {
                if (_hallSpecializationRepository == null)
                {
                    _hallSpecializationRepository = new HallSpecializationRepository(_context);
                }

                return _hallSpecializationRepository;
            }
        }

        public IWorkSpecializationRepository WorkSpecializationsRepository
        {
            get
            {
                if (_workSpecializationRepository == null)
                {
                    _workSpecializationRepository = new WorkSpecializationRepository(_context);
                }

                return _workSpecializationRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
