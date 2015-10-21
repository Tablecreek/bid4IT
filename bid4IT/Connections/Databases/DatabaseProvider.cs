using Microsoft.Data.Entity;

namespace bid4IT.Connections.Databases {
    class DatabaseProvider : DbContext  {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var databasePath = Values.Database.GetCompleteDatabaseFile();
            optionsBuilder.UseSqlite($"Data source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
        }
    }
}
