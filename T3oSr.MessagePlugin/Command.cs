using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;

namespace T3oSr.MessagePlugin
{
    public class Command : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => "woo";
        public string Help => "Send a message／發出訊息...........";
        public string Syntax => ":thonking:";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string>() { "try.woo" };
        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedChat.Say(caller, "hello world");
        }
    }
}
