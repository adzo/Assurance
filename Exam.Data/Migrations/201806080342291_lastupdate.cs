namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contrats", "ContratName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contrats", "ContratName");
        }
    }
}
