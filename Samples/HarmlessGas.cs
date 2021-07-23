/*
 * This simple plugin makes it so that gas damage is not dealt to the player.
 * This is an example of disallowing events. Most events can be disallowed. Check the documentation for which events can and can't be disallowed.
 * This is an example of the plugin framework - This code will NOT work if inserted directly into the plugins folder.
*/

using System;
using PluginAPI;
using PluginAPI.Events.EventArgs;
using PluginAPI.Events;
using VirtualBrightPlayz.SCP_ET.Player;

namespace HarmlessGasPlugin
{
    public class MainPlugin : Plugin<PluginConfig> // Inherit your class from the ET plugin class. Note that you will need to create the Config class, and inherit that from "IConfig".
    {
        public override void OnEnabled() // This method calls when the plugin is enabled.
        {
            ServerEvents.PlayerDamage += OnDamage; // Connect the event.
        }

        public override void OnDisabled() // This method calls when the plugin is disabled.
        {
            ServerEvents.PlayerDamage -= OnDamage; // Disconnect the event to save memory.
        }

        public void OnDamage(PlayerDamageEvent ev)
        {
            if (ev.AttackInfo.AttackerId == "GAS") // The "AttackerId" field of AttackInfo is unique for each attacker. In this case, the if statement will return true if the attacker is poisonous gas.
            {
                ev.Disallow(); // Disallow the event, preventing it from dealing the damage.
            }
        }
    }
}
