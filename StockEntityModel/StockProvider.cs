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

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}