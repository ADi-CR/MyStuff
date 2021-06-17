using MyStuff.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyStuff.Views
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