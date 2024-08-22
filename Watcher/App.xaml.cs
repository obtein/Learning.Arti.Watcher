using System.Configuration;
using System.Data;
using System.Windows;

namespace Watcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup ( StartupEventArgs e )
        {
            base.OnStartup( e );

            MainWindow app = new MainWindow();
            ApplicationShell context = new ApplicationShell();
            app.DataContext = context;
            app.Show();
        }
    }

}
