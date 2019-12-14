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
        public bool CreateProductStock(StockEntityModel.ProductStock productStock)
        {
            try
            {
                using(StockProvider database = new StockProvider())
                {
                    database.ProductsStock.Add(productStock);
                    database.SaveChanges();                    
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteProductStock(string productNumber)
        {
            try
            {
                using(StockProvider database = new StockProvider())
                {
                    ProductStockData productStockData = RetrieveProductStock(productNumber);
                    if(productStockData == null)
                    {
                        return false;
                    }
                    else
                    {
                        var context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)database).ObjectContext;
                        context.ExecuteStoreCommand("DELETE FROM ProductStocks WHERE Number= {0}", productNumber);
                        database.SaveChanges();                        
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
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
            ProductStockData productStockData = null;
            try
            {
                using (StockProvider database = new StockProvider())
                {
                    StockEntityModel.ProductStock productStock = database.ProductsStock.First(
                        p => String.Compare(p.Number, productNumber) == 0);
                    productStockData = ParseProductStockToProductStockData(productStock);
                }
            }
            catch
            {
                //TODO: Should be implemented in future
            }
            return productStockData;
        }

        public int RetrieveProductStockAmount(string productNumber)
        {
            try
            {
                ProductStockData productStockData = RetrieveProductStock(productNumber);
                if (productStockData != null)
                {
                    return productStockData.Amount;
                }
            }
            catch
            {
                //TODO: Should be implemented in future
            }
            return 0;                
        }

        public bool UpdateProductStockAmount(string productNumber, int productAmount)
        {
            try
            {
                StockEntityModel.ProductStock productStock = ParseProductStockDataToProductStock(RetrieveProductStock(productNumber));
                if(productStock == null)
                {
                    return false;
                }
                else
                {
                    productStock.Amount += productAmount;
                }
                            
                using (StockProvider database = new StockProvider())
                {
                    database.Entry(productStock).State = System.Data.Entity.EntityState.Modified;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private StockEntityModel.ProductStock ParseProductStockDataToProductStock(ProductStockData productStockData)
        {            
            StockEntityModel.ProductStock productStock = new StockEntityModel.ProductStock()
            {
                Number = productStockData.Number,
                Name = productStockData.Name,
                Description = productStockData.Description,
                Amount = productStockData.Amount
            };
            return productStock;
        }

        private ProductStockData ParseProductStockToProductStockData(StockEntityModel.ProductStock productStock)
        {
            ProductStockData productStockData = new ProductStockData()
            {
                Number = productStock.Number,
                Name = productStock.Name,
                Description = productStock.Description,
                Amount = productStock.Amount
            };
            return productStockData;
        }
    }
}
