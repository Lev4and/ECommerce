using DevExpress.Mvvm;
using ECommerce.DesktopApplication.Commands;
using ECommerce.HttpClients;
using ECommerce.HttpClients.Ozon.ResponseModels;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class CatalogViewModel : BindableBase
    {
        private HttpContext _httpContext;

        public bool IsLoaded { get; set; }

        public Category Category { get; set; }

        public CatalogViewModel(HttpContext httpContext)
        {
            _httpContext = httpContext;

            IsLoaded = false;
        }

        public ICommand Loaded => new AsyncCommand(() =>
        {
            return LoadedAsync();
        });

        public ICommand SelectedCategoryChanged => new Command((item) =>
        {
            var selectedCategory = ((TreeView)item).SelectedValue;
        });

        private async Task LoadedAsync()
        {
            Category = await _httpContext.Ozon.Category.GetCategoryAsync(0);

            IsLoaded = true;
        }
    }
}
