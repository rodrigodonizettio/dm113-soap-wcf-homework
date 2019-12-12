using ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using StockEntityModel;
using System.ServiceModel.Activation;

namespace StockService
{
    // WCF service that implements the service contract
    // This implementation performs minimal error checking and exception handling
    [AspNetCompatibilityRequirements(
        RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    //public class StockService : IStockService, IStockServiceV2
    public class StockService : IStockService
    {
        public bool CreateProductStock(ProductStockData productStockData)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductStock(string productNumber)
        {
            throw new NotImplementedException();
        }

        public List<string> RetrieveAllProductsStock()
        {
            List<string> productsStockDataName = new List<string>();
            try
            {
                using(StockProvider database = new StockProvider())
                {
                    List<StockEntityModel.ProductStock> productsStock = (from productStock in database.ProductsStock
                        select productStock).ToList();

                    foreach(StockEntityModel.ProductStock productStock in productsStock)
                    {
                        productsStockDataName.Add(productStock.Name);
                    }
                }
            }
            catch
            {
                //TODO: Should be implemented in future
            }
            return productsStockDataName;
        }

        public ProductStockData RetrieveProductStock(string productNumber)
        {
            throw new NotImplementedException();
        }

        public int RetrieveProductStockAmount(string productNumber)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProductStockAmount(string productNumber, int productAmount)
        {
            throw new NotImplementedException();
        }
    }
}
