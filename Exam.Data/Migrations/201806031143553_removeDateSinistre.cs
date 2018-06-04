namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDateSinistre : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Sinistres", "DateDeSinistre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sinistres", "DateDeSinistre", c => c.String());
        }
    }
}
