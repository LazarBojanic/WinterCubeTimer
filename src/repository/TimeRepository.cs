
using Microsoft.EntityFrameworkCore;
using WinterCubeTimer.model;
using WinterCubeTimer.util;

namespace WinterCubeTimer.repository {
    public class TimeRepository : DbContext {
        public DbSet<SolveTime> solveTime { get; set; }
        
        public TimeRepository(DbContextOptions<TimeRepository> options) :base(options) {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            Console.WriteLine(Util.DATABASE_CONNECTION_STRING);
            optionsBuilder.UseSqlite(Util.DATABASE_CONNECTION_STRING);
        }
    }
}