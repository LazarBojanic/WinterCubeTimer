using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WinterCubeTimer.util;

namespace WinterCubeTimer.repository;

public class TimeRepositoryFactory : IDesignTimeDbContextFactory<TimeRepository> {
    public TimeRepository CreateDbContext(string[] args) {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        Util.DATABASE_FILE_PATH = Path.Combine(path, Util.DATABASE_FILE_NAME);
        Util.DATABASE_CONNECTION_STRING = "Data Source=" + Util.DATABASE_FILE_PATH;
        var optionsBuilder = new DbContextOptionsBuilder<TimeRepository>();
        optionsBuilder.UseSqlite(Util.DATABASE_CONNECTION_STRING);
        return new TimeRepository(optionsBuilder.Options);
    }
    
}