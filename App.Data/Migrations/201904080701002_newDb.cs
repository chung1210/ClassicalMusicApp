namespace App.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        MaAlbum = c.Int(nullable: false, identity: true),
                        TenAlbum = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaAlbum);
            
            CreateTable(
                "dbo.BaiHats",
                c => new
                    {
                        MaBaiHat = c.Int(nullable: false, identity: true),
                        TenBaiHat = c.String(nullable: false, maxLength: 100),
                        LuotNghe = c.Int(nullable: false),
                        TinhTrangBaiHat = c.Int(nullable: false),
                        MoreImage = c.String(maxLength: 250),
                        Url = c.String(maxLength: 250),
                        MaCaSi = c.Int(nullable: false),
                        MaAlbum = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.MaBaiHat)
                .ForeignKey("dbo.Albums", t => t.MaAlbum, cascadeDelete: true)
                .ForeignKey("dbo.CaSies", t => t.MaCaSi, cascadeDelete: true)
                .Index(t => t.MaCaSi)
                .Index(t => t.MaAlbum);
            
            CreateTable(
                "dbo.CaSies",
                c => new
                    {
                        MaCaSi = c.Int(nullable: false, identity: true),
                        TenCaSi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaCaSi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaiHats", "MaCaSi", "dbo.CaSies");
            DropForeignKey("dbo.BaiHats", "MaAlbum", "dbo.Albums");
            DropIndex("dbo.BaiHats", new[] { "MaAlbum" });
            DropIndex("dbo.BaiHats", new[] { "MaCaSi" });
            DropTable("dbo.CaSies");
            DropTable("dbo.BaiHats");
            DropTable("dbo.Albums");
        }
    }
}
