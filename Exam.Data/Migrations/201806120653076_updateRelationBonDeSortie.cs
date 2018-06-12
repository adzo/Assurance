namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRelationBonDeSortie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BonDeSorties", "SinistreId", "dbo.Sinistres");
            RenameColumn(table: "dbo.BonDeSorties", name: "SinistreId", newName: "BonDeSortieId");
            RenameIndex(table: "dbo.BonDeSorties", name: "IX_SinistreId", newName: "IX_BonDeSortieId");
            DropPrimaryKey("dbo.BonDeSorties");
            AddPrimaryKey("dbo.BonDeSorties", "BonDeSortieId");
            AddForeignKey("dbo.BonDeSorties", "BonDeSortieId", "dbo.Sinistres", "SinistreId");
            DropColumn("dbo.BonDeSorties", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BonDeSorties", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.BonDeSorties", "BonDeSortieId", "dbo.Sinistres");
            DropPrimaryKey("dbo.BonDeSorties");
            AddPrimaryKey("dbo.BonDeSorties", "Id");
            RenameIndex(table: "dbo.BonDeSorties", name: "IX_BonDeSortieId", newName: "IX_SinistreId");
            RenameColumn(table: "dbo.BonDeSorties", name: "BonDeSortieId", newName: "SinistreId");
            AddForeignKey("dbo.BonDeSorties", "SinistreId", "dbo.Sinistres", "SinistreId", cascadeDelete: true);
        }
    }
}
