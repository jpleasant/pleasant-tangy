using Newtonsoft.Json;
using System.Collections.Generic;

namespace PluginManager_Mobile.Models
{
    public class Plugin
    {
        [JsonProperty("pluginID")]
        public int PluginID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }
        [JsonProperty("design")]
        public Design Design { get; set; }
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("manualUrl")]
        public string ManualUrl { get; set; }
        [JsonProperty("manualType")]
        public int ManualType { get; set; }
    }
}
