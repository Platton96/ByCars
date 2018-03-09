namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfieldUrlImgforCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "UrlImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "UrlImg");
        }
    }
}
