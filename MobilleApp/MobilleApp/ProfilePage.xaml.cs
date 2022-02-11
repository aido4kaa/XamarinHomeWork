using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MobilleApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private ProfilePageViewModel _vm = new ProfilePageViewModel();
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = _vm;
        }

        protected async override void OnAppearing()
        {
            BindableLayout.SetItemsSource(Books,await _vm.LoadBooks());
            base.OnAppearing();
        }

    }
}