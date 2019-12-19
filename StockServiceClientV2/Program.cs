using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using StockServiceClientV2.StockService;

namespace StockServiceClientV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            StockService.StockServiceClient proxyV2 = OpenProxyConnectionV2("WS2007HttpBinding_IStockServiceV2");

            ShouldRetrieveProductStockAmount(proxyV2);
            ShouldUpdateProductStockAmount(proxyV2);

            CloseProxyConnection(proxyV2);
        }


        public static void ShouldUpdateProductStockAmount(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - UPDATE a ProductStock AMOUNT");
            string productStockNumber = "number1";
            int newProductStockAmount = 1;
            if (proxy.UpdateProductStockAmount(productStockNumber, newProductStockAmount))
            {
                Console.WriteLine("ProductStock Number: " + productStockNumber + " had its amount updated successfully");
            }
            else
            {
                Console.WriteLine("Failed to update the amount of the ProductStock Number: " + productStockNumber);
            }
            Console.WriteLine();
        }

        public static void ShouldRetrieveProductStockAmount(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - RETRIEVE a ProductStock AMOUNT");
            string productStockNumber = "number1";
            int productStockAmount = proxy.RetrieveProductStockAmount(productStockNumber);
            Console.WriteLine("ProductStock amount is: " + productStockAmount);
            Console.WriteLine();
        }

        public static StockService.StockServiceClient OpenProxyConnectionV2(string endpointConfigurationName)
        {
            Console.WriteLine("Test - Client-2");
            return new StockService.StockServiceClient();
        }

        public static void CloseProxyConnection(StockService.StockServiceClient proxy)
        {
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
