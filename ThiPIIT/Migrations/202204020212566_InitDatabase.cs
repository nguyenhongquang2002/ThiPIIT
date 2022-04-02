namespace ThiPIIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        baseAsset = c.String(nullable: false),
                        MyProperty = c.String(nullable: false),
                        quoteAsset = c.String(nullable: false),
                        lastPrice = c.Int(nullable: false),
                        volumn24h = c.String(nullable: false),
                        MarketId = c.Int(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAd = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Markets", t => t.MarketId, cascadeDelete: true)
                .Index(t => t.MarketId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        description = c.String(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAd = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "MarketId", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "MarketId" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
