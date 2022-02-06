using System.Windows.Controls;

namespace ECommerce.DesktopApplication.Views.Pages.Category
{
    public partial class Category : Page
    {
        public string CategoryId { get; }

        public Category(string categoryId)
        {
            CategoryId = categoryId;

            InitializeComponent();
        }
    }
}
