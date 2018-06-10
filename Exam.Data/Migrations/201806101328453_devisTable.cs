namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class devisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SinistreId = c.Int(nullable: false),
                        DateDevis = c.String(),
                        Conformite = c.Boolean(nullable: false),
                        DevisUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devis", "SinistreId", "dbo.Sinistres");
            DropIndex("dbo.Devis", new[] { "SinistreId" });
            DropTable("dbo.Devis");
        }
    }
}
