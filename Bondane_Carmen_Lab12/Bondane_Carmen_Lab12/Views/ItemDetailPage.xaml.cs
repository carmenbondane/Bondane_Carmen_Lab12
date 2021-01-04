using System.ComponentModel;
using Xamarin.Forms;
using Bondane_Carmen_Lab12.ViewModels;

namespace Bondane_Carmen_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}