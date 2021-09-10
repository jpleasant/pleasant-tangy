using Newtonsoft.Json;
using plugin_manager_mobile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace plugin_manager_mobile.Services
{
    public class PluginService : IPluginService
    {
        private readonly HttpClient _client;
        public PluginService()
        {
            _client = new HttpClient();
        }
        public async Task<IEnumerable<Plugin>> GetAllPlugins()
        {           
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //_client.BaseAddress = new Uri("http://10.0.2.2:6200");
            //var responseTask = _client.GetAsync("/api/plugins");
            //var response = responseTask.Result;

            var response = _client.GetAsync(new Uri("https://jsonplaceholder.typicode.com/todos/1")).Result;
            Debug.WriteLine("response" + response);
            //var x = response.StatusCode;
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<Plugin>>(content);
            return result;

        }
    }
}
