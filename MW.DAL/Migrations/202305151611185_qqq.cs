namespace MW.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qqq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PracticeNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PracticeNumber");
        }
    }
}
