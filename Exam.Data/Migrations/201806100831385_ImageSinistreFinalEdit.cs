namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageSinistreFinalEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageSinistres", "ImageLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImageSinistres", "ImageLink");
        }
    }
}
