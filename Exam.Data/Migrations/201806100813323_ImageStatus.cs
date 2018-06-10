namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "Status");
        }
    }
}
