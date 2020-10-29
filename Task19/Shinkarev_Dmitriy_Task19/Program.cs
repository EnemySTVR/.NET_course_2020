using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Shinkarev_Dmitriy_Task19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Add connection string
            // Кусок кода добавляет строку подключения в App.settings(где бы он не был).
            // Достаточно единожды запустить приложение с ним.
            //var setting = new ConnectionStringSettings()
            //{
            //    Name = "Task17Connection",
            //    ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Task17; Integrated Security=True; Pooling=true;"
            //};

            //Configuration config;
            //config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings.Add(setting);
            //config.Save();
            #endregion
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
