using Newtonsoft.Json;

namespace PluginManager_Mobile.Models
{
    public class Tag
    {
        [JsonProperty("tagID")]
        public int TagID { get; set; }
        [JsonProperty("tagName")]
        public string TagName { get; set; }
    }
}
