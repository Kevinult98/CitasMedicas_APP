using CitasMedicas_APP.ViewModels;
using CitasMedicas_APP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CitasMedicas_APP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
