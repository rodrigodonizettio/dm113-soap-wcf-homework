﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductStock
{
    [ServiceContract]
    public interface IStockServiceV2
    {
        [OperationContract]
        bool UpdateProductStockAmount(string productNumber, int productAmount); //Improvement due to Add and Sub original project requirements
        [OperationContract]
        ProductStockData RetrieveProductStock(string productNumber);
    }
}
