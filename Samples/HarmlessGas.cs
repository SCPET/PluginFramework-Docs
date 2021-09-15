/*
 * This simple plugin makes it so that gas damage is not dealt to the player.
 * This is an example of disallowing events. Most events can be disallowed. Check the documentation for which events can and can't be disallowed.
 * This is an example of the plugin framework - This code will NOT work if inserted directly into the plugins folder.
*/

using System;
using PluginAPI;
using PluginAPI.Events.EventArgs;
using PluginAPI.Events;
using PluginAPI.Interfaces;
using SCP_ET.Player;

namespace HarmlessGasPlugin
{
    public class MainPlugin : Plugin<PluginConfig> // Inherit your class from the ET plugin class. Note that you will need to create the generic class, and inherit that from "IConfig".
    {
        public override void OnEnabled() // This method is called when the plugin is enabled.
        {
            PlayerEvents.PlayerDamage += OnDamage; // Connect the event.
        }

        public override void OnDisabled() // This method is called when the plugin is disabled.
        {
            PlayerEvents.PlayerDamage -= OnDamage; // Disconnect the event to save memory.
        }

        public void OnDamage(PlayerDamageEvent ev)
        {
            if (ev.AttackInfo.AttackerId == "GAS" && !ev.Finalized)
            {
                // The "AttackerId" field of AttackInfo is unique for each attacker. In this case, the if statement will return true if the attacker is poisonous gas.
                // We also check to ensure that Finalized is false, as Disallow() will throw an exception if called when Finalized is true (you cannot disallow something that already happened).
                ev.Disallow(); // Disallow the event, preventing it from dealing the damage.
            }
        }
    }

    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
