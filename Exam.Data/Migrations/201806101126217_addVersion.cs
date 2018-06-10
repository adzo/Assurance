namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rapports", "Version", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rapports", "Version");
        }
    }
}
