using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using StockServiceClient.StockService;

namespace StockServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            StockService.StockServiceClient proxy = OpenProxyConnection();

            ShouldCreateProductStock(proxy);            
            ShouldRetrieveAllProductsStock(proxy);
            ShouldRetrieveProductStock(proxy);
            ShouldUpdateProductStockAmount(proxy);
            ShouldRetrieveProductStockAmount(proxy);
            shouldDeleteProductStock(proxy);
            
            CloseProxyConnection(proxy);
        }


        public static void ShouldCreateProductStock(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - CREATE a ProductStock");
            StockService.ProductStock productStock = new StockService.ProductStock();
            productStock.Number = "number1";
            productStock.Name = "name1";
            productStock.Description = "description1";
            productStock.Amount = 1;

            if(proxy.CreateProductStock(productStock))
            {
                Console.WriteLine("ProductStock Name: " + productStock.Name + " was created successfully");
            }
            else
            {
                Console.WriteLine("Failed to create a new ProductStock");
            }
            Console.WriteLine();
        }

        public static void shouldDeleteProductStock(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - DELETE a ProductStock");
            string productStockNumber = "number1";
            if(proxy.DeleteProductStock(productStockNumber))
            {
                Console.WriteLine("ProductStock Number: " + productStockNumber + " was deleted successfully");
            }
            else
            {
                Console.WriteLine("Failed to delete a new ProductStock");
            }
            Console.WriteLine();
        }

        public static void ShouldRetrieveAllProductsStock(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - RETRIEVE ALL ProductsStock");
            List<string> productStockDataNames = proxy.RetrieveAllProductsStock().ToList();
            foreach (string name in productStockDataNames)
            {
                Console.WriteLine("ProductStock Name: {0}", name);
            }
            Console.WriteLine("ProductsStock were retrieved successfully");
            Console.WriteLine();
        }

        public static void ShouldRetrieveProductStock(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - RETRIEVE ProductStock BY NUMBER");
            string productStockNumber = "number1";

            StockService.ProductStockData productStockData = proxy.RetrieveProductStock(productStockNumber);

            if (productStockData != null)
            {
                Console.WriteLine("ProductStock - Number: " + productStockData.Number);
                Console.WriteLine("ProductStock - Name: " + productStockData.Name);
                Console.WriteLine("ProductStock - Description: " + productStockData.Description);
                Console.WriteLine("ProductStock - Amount: " + productStockData.Amount);
                Console.WriteLine("ProductStock Number: " + productStockNumber + " was retrieved successfully");
            }
            else
            {
                Console.WriteLine("Failed to retrieve the ProductStock Number: " + productStockNumber);
            }
            Console.WriteLine();
        }

        public static void ShouldUpdateProductStockAmount(StockService.StockServiceClient proxy)
        {
            Console.WriteLine("Test - UPDATE a ProductStock AMOUNT");
            string productStockNumber = "number1";
            int newProductStockAmount = 1;
            if(proxy.UpdateProductStockAmount(productStockNumber, newProductStockAmount))
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

        public static StockService.StockServiceClient OpenProxyConnection()
        {
            Console.WriteLine("Test - Client-1");
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
