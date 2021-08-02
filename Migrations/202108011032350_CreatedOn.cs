namespace Webpopytka_4_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedOn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HelloMigrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateOn = c.DateTime(nullable: false),
                        LastLoginTime = c.DateTime(nullable: false),
                        IsLoggedIn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastLoginTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastLoginTime");
            DropColumn("dbo.AspNetUsers", "CreatedOn");
            DropTable("dbo.HelloMigrations");
        }
    }
}
