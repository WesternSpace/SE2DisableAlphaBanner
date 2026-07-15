using Keen.VRage.Library.Diagnostics;
using Keen.VRage.Core.EngineComponents;
using Keen.VRage.Core.Plugins;
using Keen.Game2.Client.RuntimeSystems.CoreScenes;

namespace SE2DisableAlphaBanner
{
    public class Plugin : IPlugin
    {
        public Plugin(PluginHost host)
        {
            Log.Default.WriteLine($"[SE2DisableAlphaBanner] Loaded plugin");
            host.OnBeforeEngineInstantiated += Host_OnBeforeEngineInstantiated;
        }

        private void Host_OnBeforeEngineInstantiated(EngineBuilder builder)
        {
            builder.Configure<GameRenderComponentCoreConfigurationObjectBuilder>().DrawAlphaBanner = false;
        }
    }
}
