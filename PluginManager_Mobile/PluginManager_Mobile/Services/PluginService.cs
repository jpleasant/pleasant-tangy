using PluginManager_Mobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PluginManager_Mobile.Services
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
            
            var response = await _client.GetAsync(new Uri("http://10.0.2.2:6200/api/plugins"));
            //var x = response.StatusCode;
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<Plugin>>(content);
            return result;

        }

        
    }
}
