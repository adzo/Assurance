namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageRenamedImageSinistre : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Images", newName: "ImageSinistres");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ImageSinistres", newName: "Images");
        }
    }
}
