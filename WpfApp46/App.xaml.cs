using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp46.Model;

namespace WpfApp46
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection servies = new ServiceCollection();
            servies.AddDbContext<ProductDbContext>(p => { p.UseSqlite("Data Source = Task7.db"); });
            servies.AddSingleton<MainWindow>();
            serviceProvider = servies.BuildServiceProvider();
        }

        private void OnStartUp(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }

}
