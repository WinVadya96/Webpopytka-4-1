namespace Webpopytka_4_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsLoggedInTypeIsChangedToBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "IsLoggedIn", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "IsLoggedIn", c => c.Int(nullable: false));
        }
    }
}
