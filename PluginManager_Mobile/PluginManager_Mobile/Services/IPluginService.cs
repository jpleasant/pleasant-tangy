using PluginManager_Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PluginManager_Mobile.Services
{
    public interface IPluginService
    {
        Task<IEnumerable<Plugin>> GetAllPlugins();
    }
}
