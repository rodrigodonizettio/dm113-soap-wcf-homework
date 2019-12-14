using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductStock
{
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IStockService")]
    public interface IStockService
    {
        [OperationContract]
        List<string> RetrieveAllProductsStock();
        [OperationContract]
        bool CreateProductStock(StockEntityModel.ProductStock productStock);
        [OperationContract]
        bool DeleteProductStock(string productNumber);
        [OperationContract]
        int RetrieveProductStockAmount(string productNumber);
        [OperationContract]
        bool UpdateProductStockAmount(string productNumber, int productAmount); //Improvement due to Add and Sub original project requirements
        [OperationContract]
        ProductStockData RetrieveProductStock(string productNumber);
    }


    [DataContract]
    public class ProductStockData
    {
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Amount { get; set; }
    }
}