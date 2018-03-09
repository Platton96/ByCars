namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldFavoriteforbuyingCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyingCars", "FavoriteOffer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BuyingCars", "FavoriteOffer");
        }
    }
}
