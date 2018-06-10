namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageSinistreAddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageSinistres", "DateImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImageSinistres", "DateImage");
        }
    }
}
