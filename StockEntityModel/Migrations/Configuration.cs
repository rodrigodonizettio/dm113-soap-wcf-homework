namespace StockEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StockEntityModel.StockProvider>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StockEntityModel.StockProvider context)
        {
            context.ProductsStock.AddOrUpdate(
                p => p.Id,
                new ProductStock { Number = "1000", Name = "Product 1", Description = "This is the Product 1", Amount = 100 },
                new ProductStock { Number = "2000", Name = "Product 2", Description = "This is the Product 2", Amount = 10 },
                new ProductStock { Number = "3000", Name = "Product 3", Description = "This is the Product 3", Amount = 200 },
                new ProductStock { Number = "4000", Name = "Product 4", Description = "This is the Product 4", Amount = 300 },
                new ProductStock { Number = "5000", Name = "Product 5", Description = "This is the Product 5", Amount = 400 },
                new ProductStock { Number = "6000", Name = "Product 6", Description = "This is the Product 6", Amount = 500 },
                new ProductStock { Number = "7000", Name = "Product 7", Description = "This is the Product 7", Amount = 30 },
                new ProductStock { Number = "8000", Name = "Product 8", Description = "This is the Product 8", Amount = 30 },
                new ProductStock { Number = "9000", Name = "Product 9", Description = "This is the Product 9", Amount = 400 },
                new ProductStock { Number = "10000", Name = "Product 10", Description = "This is the Product 10", Amount = 2 }
            );

            context.SaveChanges();
        }
    }
}
