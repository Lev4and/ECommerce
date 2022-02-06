using DevExpress.Mvvm;
using ECommerce.DesktopApplication.Commands;
using ECommerce.DesktopApplication.Services;
using ECommerce.HttpClients;
using ECommerce.HttpClients.Ozon.ResponseModels;
using ECommerce.Model.Marketplace.Ozon.Types;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Pages = ECommerce.DesktopApplication.Views.Pages;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class CategoryViewModel : BindableBase
    {
        private readonly HttpContext _httpContext;
        private readonly MenuPageService _menuPageService;

        public bool IsLoaded { get; set; }

        public Listing Listing { get; set; }

        public ObservableCollection<Item> SearchResults { get; set; }

        public CategoryViewModel(HttpContext httpContext, MenuPageService menuPageService)
        {
            _httpContext = httpContext;
            _menuPageService = menuPageService;

            IsLoaded = false;
        }

        public ICommand Loaded => new AsyncCommand<string>((url) =>
        {
            return LoadedAsync(url);
        });

        public ICommand Search => new AsyncCommand(() =>
        {
            return SearchAsync();
        });

        public ICommand SearchStringChanged => new AsyncCommand(() =>
        {
            return Task.Run(() => { });
        });

        public ICommand GoToCategory => new Command((url) =>
        {
            _menuPageService.ChangePage(new Pages.Category.Category(Convert.ToString(url)));
        });

        public ICommand SelectedCategoryChanged => new Command((item) =>
        {
            var info = (Info)((TreeView)item).SelectedValue;

            _menuPageService.ChangePage(new Pages.Category.Category($"/category/{info.UrlValue}/"));
        });

        public ICommand ScrollViewerChanged => new AsyncCommand<object>((obj) =>
        {
            return LoadedAsync(obj as ScrollChangedEventArgs);
        });

        private async Task LoadedAsync(string categoryUrl)
        {
            Listing = await _httpContext.ResourceWebApp.Catalog.GetCatalogAsync(categoryUrl);
            SearchResults = new ObservableCollection<Item>(Listing.WidgetStates.SearchResults.Items);

            IsLoaded = true;
        }

        private async Task LoadedAsync(ScrollChangedEventArgs eventArgs)
        {
            if ((int)(eventArgs.VerticalOffset / (eventArgs.ExtentHeight - eventArgs.ViewportHeight) * 100) >= 80)
            {
                if(Listing.Shared.Catalog.CurrentPage < Listing.Shared.Catalog.TotalPages)
                {
                    IsLoaded = false;

                    Listing = await _httpContext.ResourceWebApp.Catalog.GetCatalogAsync(Listing.Shared.Catalog.CurrentUrl, 
                        Listing.Shared.Catalog.CurrentPage == 0 ? 2 : Listing.Shared.Catalog.CurrentPage + 1);

                    foreach(var item in Listing.WidgetStates.SearchResults.Items)
                    {
                        SearchResults.Add(item);
                    }

                    IsLoaded = true;
                }
            }
        }

        private async Task SearchAsync()
        {
            IsLoaded = false;



            IsLoaded = true;
        }
    }
}
