using DevExpress.Mvvm;
using ECommerce.DesktopApplication.Services;
using ECommerce.DesktopApplication.Views.Pages.Catalog;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class MenuViewModel : BindableBase
    {
        private readonly MenuPageService _menuPageService;

        public bool IsLeftDrawerOpen { get; set; }

        public Page PageSource { get; set; }

        public MenuViewModel(MenuPageService menuPageService)
        {
            _menuPageService = menuPageService;
            _menuPageService.OnPageChanged += (page) => { IsLeftDrawerOpen = false; PageSource = page; };
        }

        public ICommand OnUnchecked => new DelegateCommand(() =>
        {
            IsLeftDrawerOpen = false;
        });

        public ICommand Loaded => new AsyncCommand(() =>
        {
            return LoadedAsync();
        });

        public ICommand Catalog => new DelegateCommand(() =>
        {
            _menuPageService.ChangePage(new Catalog());
        });

        public ICommand Exit => new DelegateCommand(() =>
        {
            Application.Current.Shutdown();
        });

        private async Task LoadedAsync()
        {
            _menuPageService.ChangePage(new Catalog());
        }
    }
}
