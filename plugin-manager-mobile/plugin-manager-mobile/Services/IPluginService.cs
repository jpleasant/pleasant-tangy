using plugin_manager_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace plugin_manager_mobile.Services
{
    public interface IPluginService
    {
        Task<IEnumerable<Plugin>> GetAllPlugins();
    }
}
