using PluginAPI.Interfaces;

namespace ETTestingPlugin
{
    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public int UsesPerRound { get; set; } = 5;
        public string FailMessage { get; set; } = "SCP-914 has run out of uses this round!";
        public string UsesLeftMessage { get; set; } = "You have activated SCP-914. SCP-914 can be used %COUNT% more times this round.";
    }
}