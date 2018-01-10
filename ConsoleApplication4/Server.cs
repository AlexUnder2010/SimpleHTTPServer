using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter path to site (ex. D:\site):");
            string x = Console.ReadLine();
            string myFolder = x;
            SimpleHTTPServer myServer = new SimpleHTTPServer(myFolder, 80);
            Console.WriteLine("Server is running on this port: " + myServer.Port);
            Console.ReadLine();
        }
    }
}
