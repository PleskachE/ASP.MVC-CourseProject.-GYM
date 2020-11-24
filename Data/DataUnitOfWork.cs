using Data.Abstractions;
using Data.Abstractions.Repositories;
using Data.Repositories;

namespace Data
{
    public class DataUnitOfWork: IDataUnitOfWork
    {
        private readonly DataDbContext _context;

        private IClientRepository _clientRepository;
        private IRolesRepository _rolesRepository;
        private ITrainingGymRepository _trainingGymRepository;
        private ITrainingRepository _trainingRepository;
        private ITrainingSessionsRepository _trainingSessionsRepository;
        private ITrainingSpecializationRepository _trainingSpecializationRepository;
        private ITypeGymTrainingRepository _typeGymTrainingRepository;
        private IWorkerRepository _workerRepository;
        private IWorkSpecializationsRepository _workSpecializationsRepository;

        public DataUnitOfWork(string connectionString)
        {
            _context = new DataDbContext(connectionString);
        }

        public IClientRepository ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_context);
                }

                return _clientRepository;
            }
        }

        public IRolesRepository RolesRepository
        {
            get
            {
                if (_rolesRepository == null)
                {
                    _rolesRepository = new RolesRepository(_context);
                }

                return _rolesRepository;
            }
        }

        public ITrainingGymRepository TrainingGymRepository
        {
            get
            {
                if (_trainingGymRepository == null)
                {
                    _trainingGymRepository = new TrainingGymRepository(_context);
                }

                return _trainingGymRepository;
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

        public ITrainingSessionsRepository TrainingSessionsRepository
        {
            get
            {
                if (_trainingSessionsRepository == null)
                {
                    _trainingSessionsRepository = new TrainingSessionsRepository(_context);
                }

                return _trainingSessionsRepository;
            }
        }

        public ITrainingSpecializationRepository TrainingSpecializationRepository
        {
            get
            {
                if (_trainingSpecializationRepository == null)
                {
                    _trainingSpecializationRepository = new TrainingSpecializationRepository(_context);
                }

                return _trainingSpecializationRepository;
            }
        }

        public ITypeGymTrainingRepository TypeGymTrainingRepository
        {
            get
            {
                if (_typeGymTrainingRepository == null)
                {
                    _typeGymTrainingRepository = new TypeGymTrainingRepository(_context);
                }

                return _typeGymTrainingRepository;
            }
        }

        public IWorkerRepository WorkerRepository
        {
            get
            {
                if (_workerRepository == null)
                {
                    _workerRepository = new WorkerRepository(_context);
                }

                return _workerRepository;
            }
        }

        public IWorkSpecializationsRepository WorkSpecializationsRepository
        {
            get
            {
                if (_workSpecializationsRepository == null)
                {
                    _workSpecializationsRepository = new WorkSpecializationsRepository(_context);
                }

                return _workSpecializationsRepository;
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
