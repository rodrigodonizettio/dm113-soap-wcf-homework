﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockServiceClient.StockService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductStock", Namespace="http://schemas.datacontract.org/2004/07/StockEntityModel")]
    [System.SerializableAttribute()]
    public partial class ProductStock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductStockData", Namespace="http://schemas.datacontract.org/2004/07/ProductStock")]
    [System.SerializableAttribute()]
    public partial class ProductStockData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="StockService.IStockService")]
    public interface IStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveAllProductsStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveAllProductsStockResponse")]
        string[] RetrieveAllProductsStock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveAllProductsStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveAllProductsStockResponse")]
        System.Threading.Tasks.Task<string[]> RetrieveAllProductsStockAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/CreateProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/CreateProductStockResponse")]
        bool CreateProductStock(StockService.ProductStock productStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/CreateProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/CreateProductStockResponse")]
        System.Threading.Tasks.Task<bool> CreateProductStockAsync(StockService.ProductStock productStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/DeleteProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/DeleteProductStockResponse")]
        bool DeleteProductStock(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/DeleteProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/DeleteProductStockResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductStockAsync(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockAmountRespons" +
            "e")]
        int RetrieveProductStockAmount(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockAmountRespons" +
            "e")]
        System.Threading.Tasks.Task<int> RetrieveProductStockAmountAsync(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/UpdateProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/UpdateProductStockAmountResponse")]
        bool UpdateProductStockAmount(string productNumber, int productAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/UpdateProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/UpdateProductStockAmountResponse")]
        System.Threading.Tasks.Task<bool> UpdateProductStockAmountAsync(string productNumber, int productAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockResponse")]
        StockService.ProductStockData RetrieveProductStock(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStock", ReplyAction="http://projetoavaliativo.dm113/01/IStockService/RetrieveProductStockResponse")]
        System.Threading.Tasks.Task<StockService.ProductStockData> RetrieveProductStockAsync(string productNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockServiceChannel : StockService.IStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockServiceClient : System.ServiceModel.ClientBase<StockService.IStockService>, StockService.IStockService {
        
        public StockServiceClient() {
        }
        
        public StockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] RetrieveAllProductsStock() {
            return base.Channel.RetrieveAllProductsStock();
        }
        
        public System.Threading.Tasks.Task<string[]> RetrieveAllProductsStockAsync() {
            return base.Channel.RetrieveAllProductsStockAsync();
        }
        
        public bool CreateProductStock(StockService.ProductStock productStock) {
            return base.Channel.CreateProductStock(productStock);
        }
        
        public System.Threading.Tasks.Task<bool> CreateProductStockAsync(StockService.ProductStock productStock) {
            return base.Channel.CreateProductStockAsync(productStock);
        }
        
        public bool DeleteProductStock(string productNumber) {
            return base.Channel.DeleteProductStock(productNumber);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductStockAsync(string productNumber) {
            return base.Channel.DeleteProductStockAsync(productNumber);
        }
        
        public int RetrieveProductStockAmount(string productNumber) {
            return base.Channel.RetrieveProductStockAmount(productNumber);
        }
        
        public System.Threading.Tasks.Task<int> RetrieveProductStockAmountAsync(string productNumber) {
            return base.Channel.RetrieveProductStockAmountAsync(productNumber);
        }
        
        public bool UpdateProductStockAmount(string productNumber, int productAmount) {
            return base.Channel.UpdateProductStockAmount(productNumber, productAmount);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProductStockAmountAsync(string productNumber, int productAmount) {
            return base.Channel.UpdateProductStockAmountAsync(productNumber, productAmount);
        }
        
        public StockService.ProductStockData RetrieveProductStock(string productNumber) {
            return base.Channel.RetrieveProductStock(productNumber);
        }
        
        public System.Threading.Tasks.Task<StockService.ProductStockData> RetrieveProductStockAsync(string productNumber) {
            return base.Channel.RetrieveProductStockAsync(productNumber);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="StockService.IStockServiceV2")]
    public interface IStockServiceV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IStockServiceV2/UpdateProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/02/IStockServiceV2/UpdateProductStockAmountRespons" +
            "e")]
        bool UpdateProductStockAmount(string productNumber, int productAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IStockServiceV2/UpdateProductStockAmount", ReplyAction="http://projetoavaliativo.dm113/02/IStockServiceV2/UpdateProductStockAmountRespons" +
            "e")]
        System.Threading.Tasks.Task<bool> UpdateProductStockAmountAsync(string productNumber, int productAmount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IStockServiceV2/RetrieveProductStock", ReplyAction="http://projetoavaliativo.dm113/02/IStockServiceV2/RetrieveProductStockResponse")]
        StockService.ProductStockData RetrieveProductStock(string productNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IStockServiceV2/RetrieveProductStock", ReplyAction="http://projetoavaliativo.dm113/02/IStockServiceV2/RetrieveProductStockResponse")]
        System.Threading.Tasks.Task<StockService.ProductStockData> RetrieveProductStockAsync(string productNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockServiceV2Channel : StockService.IStockServiceV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockServiceV2Client : System.ServiceModel.ClientBase<StockService.IStockServiceV2>, StockService.IStockServiceV2 {
        
        public StockServiceV2Client() {
        }
        
        public StockServiceV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockServiceV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool UpdateProductStockAmount(string productNumber, int productAmount) {
            return base.Channel.UpdateProductStockAmount(productNumber, productAmount);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProductStockAmountAsync(string productNumber, int productAmount) {
            return base.Channel.UpdateProductStockAmountAsync(productNumber, productAmount);
        }
        
        public StockService.ProductStockData RetrieveProductStock(string productNumber) {
            return base.Channel.RetrieveProductStock(productNumber);
        }
        
        public System.Threading.Tasks.Task<StockService.ProductStockData> RetrieveProductStockAsync(string productNumber) {
            return base.Channel.RetrieveProductStockAsync(productNumber);
        }
    }
}
