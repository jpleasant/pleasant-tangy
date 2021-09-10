namespace PluginManager_Mobile.Models
{
    public class Plugin
    {
        public int pluginID { get; set; }
        public string name { get; set; }
        public int category { get; set; }
        public string type { get; set; }
        public string chain { get; set; }
        public int manufacturer { get; set; }
        public string tags { get; set; }
    }
}
