using MobilleApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilleApp.ViewModel
{
    public class ProfilePageViewModel
    {
        private const string url = "https://mocki.io/v1/d4867d8b-b5d5-4a48-a4ab-79131b5809b8";
        private HttpClient _Client = new HttpClient();


        public async Task<ObservableCollection<Book>> LoadBooks()
        {
            var content = await _Client.GetStringAsync(url);
            var book = JsonConvert.DeserializeObject<List<Book>>(content);
            return new ObservableCollection<Book>(book);
        }
    }
}
