using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PRN221_Admin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            //Config for DependencyInjection (01)
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
           // services.AddSingleton(typeof(IBookRepository), typeof(BookRepository));
            services.AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var windowBookMianagenent = serviceProvider.GetService<MainWindow>();
            windowBookMianagenent.Show();
        }
    }
}
