namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabasemigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Detail = c.String(nullable: false),
                        Image = c.Binary(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arts", "UserId", "dbo.Users");
            DropIndex("dbo.Arts", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Arts");
        }
    }
}
