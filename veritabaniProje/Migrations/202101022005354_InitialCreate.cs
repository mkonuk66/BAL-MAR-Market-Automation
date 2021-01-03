namespace veritabaniProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tUruns",
                c => new
                    {
                        urunId = c.Int(nullable: false, identity: true),
                        urunAdi = c.String(),
                        miktar = c.Int(nullable: false),
                        satisFiyat = c.Int(nullable: false),
                        irsaliyeNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urunId);
            CreateTable(
                "dbo.tIrsaliyes",
                c => new
                {
                    irsaliyeId = c.Int(nullable: false, identity: true),
                    urunId = c.Int(nullable: false),
                    urunAdi = c.String(),
                    miktar = c.Int(nullable: false),
                    satisFiyat = c.Int(nullable: false),
                    irsaliyeNo = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.urunId);

        }
        
        public override void Down()
        {
            DropTable("dbo.tUruns");
        }
    }
}
