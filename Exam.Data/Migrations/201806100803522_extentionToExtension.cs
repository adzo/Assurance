namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extentionToExtension : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Extension", c => c.String());
            DropColumn("dbo.Images", "Extention");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Extention", c => c.String());
            DropColumn("dbo.Images", "Extension");
        }
    }
}
