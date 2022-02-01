using ECommerce.DesktopApplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using OzonHttpClients = ECommerce.HttpClients.Ozon;
using ResourceWebAppHttpClients = ECommerce.HttpClients.ResourceWebApp;

namespace ECommerce.DesktopApplication.ViewModels.Locators
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public MainWindowViewModel MainWindowViewModel => _provider.GetService<MainWindowViewModel>();

        public MenuViewModel MenuViewModel => _provider.GetService<MenuViewModel>();

        public static void Init()
        {
            var services = new ServiceCollection();

            services.AddSingleton<OzonHttpClients.CategoryHttpClient>();
            services.AddSingleton<OzonHttpClients.HomeHttpClient>();
            services.AddSingleton<OzonHttpClients.ListingHttpClient>();
            services.AddSingleton<OzonHttpClients.ProductHttpClient>();
            services.AddSingleton<OzonHttpClients.OzonHttpContext>();

            services.AddSingleton<ResourceWebAppHttpClients.CatalogHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.CategoryHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.ProductHttpClient>();
            services.AddSingleton<ResourceWebAppHttpClients.ResourceWebAppHttpContext>();

            services.AddSingleton<HttpClients.HttpContext>();

            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<MenuViewModel>();

            services.AddSingleton<PageService>();
            services.AddSingleton<WindowService>();
            services.AddSingleton<MenuPageService>();

            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }
    }
}
