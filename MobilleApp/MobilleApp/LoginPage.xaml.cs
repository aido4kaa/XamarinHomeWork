using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginPageViewModel _vm = new LoginPageViewModel();

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = _vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Toast("Профиль");
            _vm.Navigate();
        }

        private static void Toast(string message)
        {
            ToastConfig toastConfig = new ToastConfig(message);
            toastConfig.SetDuration(500);
            UserDialogs.Instance.Toast(toastConfig);
        }
    }
}