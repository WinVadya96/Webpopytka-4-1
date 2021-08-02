namespace Webpopytka_4_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestTableIsDeleted : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.HelloMigrations");
        }
        
        public override void Down()
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
            
        }
    }
}
