namespace MW.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemorizeWords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PasswordText = c.String(),
                        UserID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 20),
                        Surname = c.String(maxLength: 30),
                        EMail = c.String(maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        RoleID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserRoles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PaymentType = c.String(),
                        PaymentPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WordPools",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        UserID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        EnglishText = c.String(),
                        TurkishText = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WordWordPools",
                c => new
                    {
                        Word_ID = c.Guid(nullable: false),
                        WordPool_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Word_ID, t.WordPool_ID })
                .ForeignKey("dbo.Words", t => t.Word_ID, cascadeDelete: true)
                .ForeignKey("dbo.WordPools", t => t.WordPool_ID, cascadeDelete: true)
                .Index(t => t.Word_ID)
                .Index(t => t.WordPool_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "UserID", "dbo.Users");
            DropForeignKey("dbo.WordWordPools", "WordPool_ID", "dbo.WordPools");
            DropForeignKey("dbo.WordWordPools", "Word_ID", "dbo.Words");
            DropForeignKey("dbo.WordPools", "UserID", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleID", "dbo.UserRoles");
            DropForeignKey("dbo.Payments", "ID", "dbo.Users");
            DropIndex("dbo.WordWordPools", new[] { "WordPool_ID" });
            DropIndex("dbo.WordWordPools", new[] { "Word_ID" });
            DropIndex("dbo.WordPools", new[] { "UserID" });
            DropIndex("dbo.Payments", new[] { "ID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Passwords", new[] { "UserID" });
            DropTable("dbo.WordWordPools");
            DropTable("dbo.Words");
            DropTable("dbo.WordPools");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Payments");
            DropTable("dbo.Users");
            DropTable("dbo.Passwords");
        }
    }
}
