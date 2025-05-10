using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace DiscordRichPresenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string clientId = "";

            var client = new DiscordRpcClient(clientId);

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Playing Online Mode",
                State = "In a Lobby",
                Assets = new Assets()
                {
                    LargeImageKey = "gta",               
                    LargeImageText = "Grand Theft Auto VI",
                    SmallImageKey = "gta",          
                    SmallImageText = "Grand Theft Auto VI"
                }
            });

            Console.WriteLine("Presence set! Press any key to exit.");
            Console.ReadKey();

            client.Dispose();
        }
    }
}
