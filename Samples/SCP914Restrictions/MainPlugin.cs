using System;
using PluginAPI;
using PluginAPI.Events;
using PluginAPI.Enums;

namespace ETTestingPlugin
{
    public class MainPlugin : Plugin<PluginConfig>
    {
        public override string Name => "SCP914Restrictions"; // You must set the name of the plugin.
        public override string Author => "Thunder"; // The author of the plugin.
        public override Version Version => new Version(1, 0, 0); // The version of the plugin. This MUST be changed when updates are released.
        public override PluginPriority Priority => PluginPriority.Low; // Tells the server that this plugin has a lower-than-standard loading priority.

        EventHandlers handlers;

        public override void OnEnabled()
        {
            handlers = new EventHandlers(this); // Creates an EventHandlers class to handle events.
            ServerEvents.RoundStart += handlers.OnRoundStart; // Subscribes to the round start event.
            ScpEvents.Scp914Activate += handlers.OnScp914Activate; // Subscribes to the SCP-914 activate event.
        }

        public override void OnDisabled()
        {
            ServerEvents.RoundStart -= handlers.OnRoundStart; // Unsubscribes from the round start event.
            ScpEvents.Scp914Activate -= handlers.OnScp914Activate; // Unsubscribes from the SCP-914 activate event.
            handlers = null; // Remove the EventHandlers class, since we no longer need it.
        }
    }
}
