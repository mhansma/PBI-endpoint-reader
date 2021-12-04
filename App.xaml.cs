using System.Windows;

namespace Power_BI_endpoint_reader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mw = new();
            if (e.Args.Length > 0)
            {
                mw.Server.Text = e.Args[0];
            }

            if (e.Args.Length > 1)
            {
                mw.Database.Text = e.Args[1];
            }
            mw.Show();
        }
    }
}
