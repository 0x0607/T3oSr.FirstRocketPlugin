using Rocket.Core.Plugins;
using Rocket.API.Collections;
using System;

namespace T3oSr.MessagePlugin
{
    class Main : RocketPlugin<Configuration>
    {
        /*********************************************************************/
        public static void Msg(string message) { Console.WriteLine(message); }
        public static void Msg(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /*********************************************************************/
        protected override void Load()
        {
            Msg("[INFO]\0成功加載.......",ConsoleColor.Green);
        }
        protected override void Unload()
        {
            Msg("[INFO]\0成功卸載.......", ConsoleColor.Green);
        }
        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "NotFound", "Failed.." },
        };
    }

}

