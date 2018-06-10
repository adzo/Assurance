namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                        Extention = c.String(),
                        SinistreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinistres", t => t.SinistreId, cascadeDelete: true)
                .Index(t => t.SinistreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "SinistreId", "dbo.Sinistres");
            DropIndex("dbo.Images", new[] { "SinistreId" });
            DropTable("dbo.Images");
        }
    }
}
