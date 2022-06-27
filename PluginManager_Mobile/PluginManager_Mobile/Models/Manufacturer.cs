using Newtonsoft.Json;

namespace PluginManager_Mobile.Models
{
    public class Manufacturer
    {
        [JsonProperty("manufacturerID")]
        public int ManufacturerID { get; set; }
        [JsonProperty("manufacturerName")]
        public string ManufacturerName { get; set; }
    }
}
