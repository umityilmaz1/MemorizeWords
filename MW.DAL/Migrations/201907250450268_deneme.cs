namespace MW.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WordWordPools", "Word_ID", "dbo.Words");
            DropForeignKey("dbo.WordWordPools", "WordPool_ID", "dbo.WordPools");
            DropIndex("dbo.WordWordPools", new[] { "Word_ID" });
            DropIndex("dbo.WordWordPools", new[] { "WordPool_ID" });
            CreateTable(
                "dbo.RelationWordAndWordPools",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        WordID = c.Guid(nullable: false),
                        WordPoolID = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Words", t => t.WordID, cascadeDelete: true)
                .ForeignKey("dbo.WordPools", t => t.WordPoolID, cascadeDelete: true)
                .Index(t => t.WordID)
                .Index(t => t.WordPoolID);
            
            DropTable("dbo.WordWordPools");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WordWordPools",
                c => new
                    {
                        Word_ID = c.Guid(nullable: false),
                        WordPool_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Word_ID, t.WordPool_ID });
            
            DropForeignKey("dbo.RelationWordAndWordPools", "WordPoolID", "dbo.WordPools");
            DropForeignKey("dbo.RelationWordAndWordPools", "WordID", "dbo.Words");
            DropIndex("dbo.RelationWordAndWordPools", new[] { "WordPoolID" });
            DropIndex("dbo.RelationWordAndWordPools", new[] { "WordID" });
            DropTable("dbo.RelationWordAndWordPools");
            CreateIndex("dbo.WordWordPools", "WordPool_ID");
            CreateIndex("dbo.WordWordPools", "Word_ID");
            AddForeignKey("dbo.WordWordPools", "WordPool_ID", "dbo.WordPools", "ID", cascadeDelete: true);
            AddForeignKey("dbo.WordWordPools", "Word_ID", "dbo.Words", "ID", cascadeDelete: true);
        }
    }
}
