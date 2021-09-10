using System.Net.Http;
using Xamarin.Forms;

namespace PluginManager_Mobile
{
    public partial class MainPage : ContentPage
    {
        private HttpClient _client;
        public MainPage()
        {
            _client = new HttpClient();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            var response = await _client.GetStringAsync("http://10.0.2.2:6200/api/plugins");
            mainText.Text = response;
            base.OnAppearing();
        }
    }
}
