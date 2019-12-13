namespace StockEntityModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class StockProvider : DbContext
    {
        // Your context has been configured to use a 'StockProvider' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StockEntityModel.StockProvider' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StockProvider' 
        // connection string in the application configuration file.
        public StockProvider()
            : base("name=StockProvider")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ProductStock> ProductsStock { get; set; }
    }

    public class ProductStock
    {
        [Required(ErrorMessage = "The ID field is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The NUMBER field is required")] //TODO: Number should be unique, shouldn't it?
        public string Number { get; set; }
        [Required(ErrorMessage = "The NAME field is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "The STOCK field is required")]
        public int Amount { get; set; }
    }
}