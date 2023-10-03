namespace _02_C21TH2_TranQuangNhat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KHOA",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 2),
                        TenKH = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.SINHVIENs",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 3),
                        HoTen = c.String(maxLength: 50),
                        SoMon = c.Int(nullable: false),
                        MaKH = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.KHOA", t => t.MaKH)
                .Index(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SINHVIENs", "MaKH", "dbo.KHOA");
            DropIndex("dbo.SINHVIENs", new[] { "MaKH" });
            DropTable("dbo.SINHVIENs");
            DropTable("dbo.KHOA");
        }
    }
}
