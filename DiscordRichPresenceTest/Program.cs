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
                Details = "VS IDE",
                State = "Windows 10",
                Assets = new Assets()
                {
                    LargeImageKey = "beats",               
                    LargeImageText = "Visual Studio 2022",
                    SmallImageKey = "beats",          
                    SmallImageText = "Visual Studio 2022"
                }
            });

            Console.WriteLine("Presence set! Press any key to exit.");
            Console.ReadKey();

            client.Dispose();
        }
    }
}
