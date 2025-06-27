using Microsoft.EntityFrameworkCore;
using WinterCubeTimer.view;
using Microsoft.Extensions.DependencyInjection;
using WinterCubeTimer.repository;
using WinterCubeTimer.service;
using WinterCubeTimer.util;

namespace WinterCubeTimer.main{
    internal static class Program{
        [STAThread]
        static void Main(){
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Util.DATABASE_FILE_PATH = Path.Combine(path, Util.DATABASE_FILE_NAME);
            Util.DATABASE_CONNECTION_STRING = "Data Source=" + Util.DATABASE_FILE_PATH;
            services.AddDbContext<TimeRepository>(options => {
                options.UseSqlite(Util.DATABASE_CONNECTION_STRING);
            });
            services.AddSingleton<ITimeService, TimeService>();
            services.AddSingleton<WinterCubeTimerForm>();
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<TimeRepository>();
            dbContext.Database.EnsureCreated();
            dbContext.SaveChanges();
            var timeServiceService = serviceProvider.GetRequiredService<ITimeService>();
            var winterCubeTimerForm = serviceProvider.GetRequiredService<WinterCubeTimerForm>();
            Application.Run(winterCubeTimerForm);
            dbContext.Dispose();
        }
    }
    
}