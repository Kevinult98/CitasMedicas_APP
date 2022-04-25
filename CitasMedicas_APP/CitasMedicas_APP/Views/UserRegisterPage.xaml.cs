using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CitasMedicas_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserRegisterPage : ContentPage
    {
        public UserRegisterPage()
        {
            InitializeComponent();
        }

        public void CmdSeePassword(object sender, ToggledEventArgs e)
        {
            if (SeePass.IsToggled)
            {
                TxtPass.IsPassword = false;
            }
            else
            {
                TxtPass.IsPassword = true;
            }
        }
    }
}