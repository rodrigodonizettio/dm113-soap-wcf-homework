using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using  StockService;

namespace StockServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost stockServiceHost = new ServiceHost(typeof(StockService.StockService));
            stockServiceHost.Open();
            Console.WriteLine("Service is running");
            Console.WriteLine("Type any key to stop it");

            Console.ReadLine();
            Console.WriteLine("Service is being stopped");
            stockServiceHost.Close();
        }
    }
}
