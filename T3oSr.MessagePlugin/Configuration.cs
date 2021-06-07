using Rocket.API;

namespace T3oSr.MessagePlugin
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string Value { get; set; }
        public void LoadDefaults()
        {
            Value = "Hello";
        }
    }
}
