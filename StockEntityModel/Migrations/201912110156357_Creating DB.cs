namespace StockEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductStocks");
        }
    }
}
