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
    internal class LoginPageViewModel
    {
        public async void Navigate()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProfilePage());
        }
    }
}
