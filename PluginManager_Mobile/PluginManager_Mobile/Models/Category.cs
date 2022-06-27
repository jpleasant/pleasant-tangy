using Newtonsoft.Json;

namespace PluginManager_Mobile.Models
{
    public class Category
    {
        [JsonProperty("categoryID")]
        public int CategoryID { get; set; }
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }
}
