using DevExpress.Mvvm;
using ECommerce.DesktopApplication.Services;
using System.Windows.Controls;
using Pages = ECommerce.DesktopApplication.Views.Pages;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly PageService _pageService;

        public Page PageSource { get; set; }

        public MainWindowViewModel(PageService pageService)
        {
            _pageService = pageService;

            _pageService.OnPageChanged += (page) => PageSource = page;
            _pageService.ChangePage(new Pages.Menu.Menu());
        }
    }
}
