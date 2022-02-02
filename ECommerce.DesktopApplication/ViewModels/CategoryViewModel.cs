using DevExpress.Mvvm;
using ECommerce.HttpClients;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ECommerce.DesktopApplication.ViewModels
{
    public class CategoryViewModel : BindableBase
    {
        private HttpContext _httpContext;

        public bool IsLoaded { get; set; }

        public CategoryViewModel(HttpContext httpContext)
        {
            _httpContext = httpContext;

            IsLoaded = false;
        }

        public ICommand Loaded => new AsyncCommand(() =>
        {
            return LoadedAsync();
        });

        private async Task LoadedAsync()
        {
            IsLoaded = true;
        }
    }
}
