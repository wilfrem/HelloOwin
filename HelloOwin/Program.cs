using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daemonizer;
using Microsoft.Owin.Hosting;

namespace HelloOwin
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 12345;
            
            using (WebApp.Start<Startup>("http://+:"+port))
            {
                Console.WriteLine("Server started at " + port);
                try
                {
                    Daemon.Instance.WaitForUnixSignal();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("not in *nix platform. wait using Console.ReadLine");
                    Console.ReadLine();
                }
            }
        }
    }
}
