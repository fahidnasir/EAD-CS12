namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedacolumninUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreatedAt");
        }
    }
}
