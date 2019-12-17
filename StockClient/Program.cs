using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using StockClient.StockService;
using StockClient.StockServiceV2;

namespace StockClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy object and connect to the service
            StockService.StockServiceClient proxy = new StockService.StockServiceClient();

            // Test the operations in the service
            // Obtain a list of all products
            Console.WriteLine("Test 1: List all products");
            List<string> productStockDataNames = proxy.RetrieveAllProductsStock().ToList();
            foreach (string name in productStockDataNames)
            {
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Disconnect from the service
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
