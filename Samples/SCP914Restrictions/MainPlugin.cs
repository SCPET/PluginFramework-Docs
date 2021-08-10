using System;
using PluginAPI;
using PluginAPI.Events;
using PluginAPI.Enums;

namespace ETTestingPlugin
{
    public class MainPlugin : Plugin<PluginConfig>
    {
        public override string Name => "SCP914Restrictions";
        public override string Author => "Thunder";
        public override Version Version => new Version(1, 0, 0);
        public override PluginPriority Priority => PluginPriority.Low;

        EventHandlers handlers;

        public override void OnEnabled()
        {
            handlers = new EventHandlers(this);
            ServerEvents.RoundStart += handlers.OnRoundStart;
            ScpEvents.Scp914Activate += handlers.OnScp914Activate;
        }

        public override void OnDisabled()
        {
            ServerEvents.RoundStart -= handlers.OnRoundStart;
            ScpEvents.Scp914Activate -= handlers.OnScp914Activate;
            handlers = null;
        }
    }
}
