using PluginAPI.Events.EventArgs;

namespace ETTestingPlugin
{
    public class EventHandlers
    {
        public MainPlugin plugin;
        public int uses = -1;

        public EventHandlers(MainPlugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnRoundStart(RoundStartEvent ev)
        {
            uses = plugin.Config.UsesPerRound;
        }

        public void OnScp914Activate(Scp914ActivateEvent ev)
        {

            if (uses <= 0 && !ev.Finalized)
            {
                ev.Player.Broadcast(plugin.Config.FailMessage, 5f);
                ev.Disallow();
            }
            else if (uses > 0 && ev.Finalized)
            {
                uses--;
                ev.Player.Broadcast(plugin.Config.UsesLeftMessage.Replace("%COUNT%", uses.ToString()), 5f);
            }
        }
    }
}
