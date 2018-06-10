namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rapport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rapports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRapport = c.String(),
                        RapportName = c.String(),
                        RapportUrl = c.String(),
                        RapportExtension = c.String(),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rapports", "SinistreId", "dbo.Sinistres");
            DropIndex("dbo.Rapports", new[] { "SinistreId" });
            DropTable("dbo.Rapports");
        }
    }
}
