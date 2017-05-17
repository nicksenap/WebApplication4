namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_currency_to_rates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rates", "BaseCurrency", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rates", "BaseCurrency");
        }
    }
}
