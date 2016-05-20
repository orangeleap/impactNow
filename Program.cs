using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace OwinSelfhostSample
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:10281/";

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Hosting on port: 10281.  Browse to http://localhost:10281");
                Console.WriteLine("Press esc to exit.");
                while (true)
                {
                    
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                
            }

            
        }
    }
}
