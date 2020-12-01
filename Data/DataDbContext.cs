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
            modelBuilder.Entity<WorkSpecialization>().ToTable(nameof(WorkSpecialization));
            modelBuilder.Entity<HallSpecialization>().ToTable(nameof(HallSpecialization));
            modelBuilder.Entity<Specialization>().ToTable(nameof(Specialization));
            modelBuilder.Entity<Session>().ToTable(nameof(Session));
            modelBuilder.Entity<Hall>().ToTable(nameof(Hall));
            modelBuilder.Entity<Training>().ToTable(nameof(Training));
            modelBuilder.Entity<Role>().ToTable(nameof(Role));
        }
    }
}
