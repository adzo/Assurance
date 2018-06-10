namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class devisTableEditConformity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devis", "Conformite", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Devis", "Conformite", c => c.Boolean(nullable: false));
        }
    }
}
