using ProductStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StockService
{    
    public class Service1 : IStockService, IStockServiceV2
    {
        public bool CreateProductStock(ProductStockData productStockData)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductStock(string productNumber)
        {
            throw new NotImplementedException();
        }

        public List<string> RetrieveAllProducts()
        {
            throw new NotImplementedException();
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
