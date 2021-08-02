namespace Webpopytka_4_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastLoginTimeIsMadeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "LastLoginTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LastLoginTime", c => c.DateTime(nullable: false));
        }
    }
}
