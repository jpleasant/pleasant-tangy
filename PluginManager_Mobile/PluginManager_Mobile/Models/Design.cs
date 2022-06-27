using Newtonsoft.Json;

namespace PluginManager_Mobile.Models
{
    public class Design
    {
        [JsonProperty("designID")]
        public int DesignID { get; set; }
        [JsonProperty("designName")]
        public string DesignName { get; set; }
    }
}
