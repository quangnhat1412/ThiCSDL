namespace _02_C21TH2_TranQuangNhat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KETQUA",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 3),
                        MaMH = c.String(nullable: false, maxLength: 2),
                        Diem = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaSV, t.MaMH })
                .ForeignKey("dbo.MONHOC", t => t.MaMH, cascadeDelete: true)
                .ForeignKey("dbo.SINHVIENs", t => t.MaSV, cascadeDelete: true)
                .Index(t => t.MaSV)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.MONHOC",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 2),
                        TenMH = c.String(maxLength: 45),
                        SoTiet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaMH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KETQUA", "MaSV", "dbo.SINHVIENs");
            DropForeignKey("dbo.KETQUA", "MaMH", "dbo.MONHOC");
            DropIndex("dbo.KETQUA", new[] { "MaMH" });
            DropIndex("dbo.KETQUA", new[] { "MaSV" });
            DropTable("dbo.MONHOC");
            DropTable("dbo.KETQUA");
        }
    }
}
