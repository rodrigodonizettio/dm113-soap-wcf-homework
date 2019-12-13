﻿using ProductStock;
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
                    return true;
                }
            }
            catch
            {
                return false;
            }
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
            ProductStockData productStockData = null;
            try
            {
                using (StockProvider database = new StockProvider())
                {
                    StockEntityModel.ProductStock productStock = database.ProductsStock.First(
                        p => String.Compare(p.Number, productNumber) == 0);
                    productStockData = new ProductStockData()
                    {
                        Number = productStock.Number,
                        Name = productStock.Name,
                        Description = productStock.Description,
                        Amount = productStock.Amount
                    };
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
            throw new NotImplementedException();
        }

        public bool UpdateProductStockAmount(string productNumber, int productAmount)
        {
            throw new NotImplementedException();
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