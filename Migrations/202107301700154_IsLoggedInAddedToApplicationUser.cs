namespace Webpopytka_4_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsLoggedInAddedToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsLoggedIn", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsLoggedIn");
        }
    }
}
