using PluginAPI.Events.EventArgs;

namespace ETTestingPlugin
{
    public class EventHandlers
    {
        public MainPlugin plugin;
        public int uses = -1; // This variable is used by the rest of the code to determine how many uses are left. It is reset on round start.

        public EventHandlers(MainPlugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnRoundStart(RoundStartEvent ev) // Round Start event
        {
            uses = plugin.Config.UsesPerRound; // Sets the uses. This is set on round start so that uses are reset at the start of every round.
        }

        public void OnScp914Activate(Scp914ActivateEvent ev) // SCP-914 Activate event
        {
            // Finalized = The event has already happened, and it cannot be Disallowed().
            // !Finalized = The event has not occurred yet, and it can be disallowed by any plugin.

            if (uses <= 0 && !ev.Finalized) // Checks if there are no uses and SCP-914 hasn't been activated yet. Disallows if both of these are true. You CANNOT call Disallow() if the event is Finalized.
            {
                ev.Player.Broadcast(plugin.Config.FailMessage, 5f); // Displays the "FailMessage" config to the player who attempted to activate SCP-914.
                ev.Disallow(); // Prevents the event from executing.
            }
            else if (uses > 0 && ev.Finalized) // Checks if there are uses left and if the event IS Finalized. Other plugins can disallow this event, so it is good practice to ensure that the event DID actually happen before taking away a usage.
            {
                uses--; // Removes one usage.
                ev.Player.Broadcast(plugin.Config.UsesLeftMessage.Replace("%COUNT%", uses.ToString()), 5f); // Displays the "UsesLeftMessage" config to the player, replacing "%COUNT%" with the amount of uses remaining.
            }
        }
    }
}
