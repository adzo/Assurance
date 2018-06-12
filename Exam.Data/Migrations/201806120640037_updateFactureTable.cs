namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateFactureTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factures", "LinkFacture", c => c.String());
            DropColumn("dbo.Factures", "Description");
            DropColumn("dbo.Factures", "Montant");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factures", "Montant", c => c.Int(nullable: false));
            AddColumn("dbo.Factures", "Description", c => c.String());
            DropColumn("dbo.Factures", "LinkFacture");
        }
    }
}
