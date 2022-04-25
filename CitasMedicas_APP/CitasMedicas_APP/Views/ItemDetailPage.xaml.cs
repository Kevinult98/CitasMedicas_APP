using CitasMedicas_APP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CitasMedicas_APP.Views
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