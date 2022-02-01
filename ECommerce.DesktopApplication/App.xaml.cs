using ECommerce.DesktopApplication.ViewModels.Locators;
using System.Windows;

namespace ECommerce.DesktopApplication
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModelLocator.Init();

            base.OnStartup(e);
        }
    }
}
