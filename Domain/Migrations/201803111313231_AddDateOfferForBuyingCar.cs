namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateOfferForBuyingCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyingCars", "DateOffer", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BuyingCars", "DateOffer");
        }
    }
}
