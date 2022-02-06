using DevExpress.Mvvm;
using ECommerce.DesktopApplication.Commands;
using ECommerce.DesktopApplication.Services;
using ECommerce.HttpClients;
using ECommerce.HttpClients.Ozon.ResponseModels;
using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Pages = ECommerce.DesktopApplication.Views.Pages;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class CatalogViewModel : BindableBase
    {
        private readonly HttpContext _httpContext;
        private readonly MenuPageService _menuPageService;

        public bool IsLoaded { get; set; }

        public Category Category { get; set; }

        public CatalogViewModel(HttpContext httpContext, MenuPageService menuPageService)
        {
            _httpContext = httpContext;
            _menuPageService = menuPageService;

            IsLoaded = false;
        }

        public ICommand Loaded => new AsyncCommand(() =>
        {
            return LoadedAsync();
        });

        public ICommand SelectedCategoryChanged => new Command((item) =>
        {
            _menuPageService.ChangePage(new Pages.Category.Category(Convert.ToString(((TreeView)item).SelectedValue)));
        });

        private async Task LoadedAsync()
        {
            Category = await _httpContext.ResourceWebApp.Category.GetCategoryAsync();

            IsLoaded = true;
        }
    }
}
