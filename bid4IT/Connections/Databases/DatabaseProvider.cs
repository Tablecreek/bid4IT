using bid4IT.Models.Database;
using Microsoft.Data.Entity;

namespace bid4IT.Connections.Databases {
    class DatabaseProvider : DbContext  {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var databasePath = Values.Database.GetCompleteDatabaseFile();
            optionsBuilder.UseSqlite($"Data source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Address>();
            modelBuilder.Entity<City>();
            modelBuilder.Entity<ContactType>();
            modelBuilder.Entity<Event>();
            modelBuilder.Entity<EventState>();
            modelBuilder.Entity<EventStore>();
            modelBuilder.Entity<EventTrigger>();
            modelBuilder.Entity<Job>();
            modelBuilder.Entity<Person>();
            modelBuilder.Entity<PersonType>();
            modelBuilder.Entity<Phone>();
            modelBuilder.Entity<School>();
        }
    }
}
