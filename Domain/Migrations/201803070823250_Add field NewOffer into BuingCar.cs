namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddfieldNewOfferintoBuingCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyingCars", "NewOffer", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cars", "Transmission", c => c.Int());
            AlterColumn("dbo.Cars", "EnginesType", c => c.Int());
            AlterColumn("dbo.Cars", "Mileage", c => c.Int());
            AlterColumn("dbo.Cars", "EngineCapacity", c => c.Int());
            AlterColumn("dbo.Cars", "DriveUnit", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "DriveUnit", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "EngineCapacity", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "Mileage", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "EnginesType", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "Transmission", c => c.Int(nullable: false));
            DropColumn("dbo.BuyingCars", "NewOffer");
        }
    }
}
