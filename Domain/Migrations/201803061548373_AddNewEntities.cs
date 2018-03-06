namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyingCars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        Car_Id = c.Int(),
                        OwnerCar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.OwnerCars", t => t.OwnerCar_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.OwnerCar_Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Transmission = c.Int(nullable: false),
                        EnginesType = c.Int(nullable: false),
                        Mileage = c.Int(nullable: false),
                        EngineCapacity = c.Int(nullable: false),
                        CarBody = c.String(),
                        DriveUnit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OwnerCars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Country = c.String(),
                        Region = c.String(),
                        District = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SearchQueries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        YearLowerLimit = c.Int(),
                        YearUpperLimit = c.Int(),
                        CostLowerLimit = c.Decimal(precision: 18, scale: 2),
                        CostUpperLimit = c.Decimal(precision: 18, scale: 2),
                        Transmission = c.Int(nullable: false),
                        EnginesType = c.Int(nullable: false),
                        MileageLowerLimit = c.Int(),
                        MileageUpperLimit = c.Int(),
                        EngineCapacityLowerLimit = c.Int(),
                        EngineCapacityUpperLimit = c.Int(),
                        CarBody = c.String(),
                        DriveUnit = c.Int(nullable: false),
                        Country = c.String(),
                        Region = c.String(),
                        District = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SearchQueries", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BuyingCars", "OwnerCar_Id", "dbo.OwnerCars");
            DropForeignKey("dbo.BuyingCars", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.BuyingCars", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.SearchQueries", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.BuyingCars", new[] { "OwnerCar_Id" });
            DropIndex("dbo.BuyingCars", new[] { "Car_Id" });
            DropIndex("dbo.BuyingCars", new[] { "ApplicationUser_Id" });
            DropTable("dbo.SearchQueries");
            DropTable("dbo.OwnerCars");
            DropTable("dbo.Cars");
            DropTable("dbo.BuyingCars");
        }
    }
}
