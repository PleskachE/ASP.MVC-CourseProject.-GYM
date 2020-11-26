using Data.Entity;

using System.Data.Entity;

namespace Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(string connectionString) : base(connectionString)
        {
            var config = new DataDbConfig();
            DbConfiguration.SetConfiguration(config);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable(nameof(User));
            modelBuilder.Entity<WorkSpecializations>().ToTable(nameof(WorkSpecializations));
            modelBuilder.Entity<TypeGymTraining>().ToTable(nameof(TypeGymTraining));
            modelBuilder.Entity<TrainingSpecialization>().ToTable(nameof(TrainingSpecialization));
            modelBuilder.Entity<TrainingSessions>().ToTable(nameof(TrainingSessions));
            modelBuilder.Entity<TrainingGym>().ToTable(nameof(TrainingGym));
            modelBuilder.Entity<Training>().ToTable(nameof(Training));
            modelBuilder.Entity<Roles>().ToTable(nameof(Roles));
        }
    }
}
