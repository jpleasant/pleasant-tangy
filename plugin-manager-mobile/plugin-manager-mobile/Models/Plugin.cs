using System;
using System.Collections.Generic;
using System.Text;

namespace plugin_manager_mobile.Models
{
    public class Plugin
    {
        public int PluginID { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public string Type { get; set; }
        public string Chain { get; set; }
        public int Manufacturer { get; set; }
        public string Tags { get; set; }
    }

}
