namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRelationTableUserSinistre : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UsersSinistres", name: "UserId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UsersSinistres", name: "SinistreId", newName: "UserId");
            RenameColumn(table: "dbo.UsersSinistres", name: "__mig_tmp__0", newName: "SinistreId");
            RenameIndex(table: "dbo.UsersSinistres", name: "IX_UserId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UsersSinistres", name: "IX_SinistreId", newName: "IX_UserId");
            RenameIndex(table: "dbo.UsersSinistres", name: "__mig_tmp__0", newName: "IX_SinistreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UsersSinistres", name: "IX_SinistreId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UsersSinistres", name: "IX_UserId", newName: "IX_SinistreId");
            RenameIndex(table: "dbo.UsersSinistres", name: "__mig_tmp__0", newName: "IX_UserId");
            RenameColumn(table: "dbo.UsersSinistres", name: "SinistreId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UsersSinistres", name: "UserId", newName: "SinistreId");
            RenameColumn(table: "dbo.UsersSinistres", name: "__mig_tmp__0", newName: "UserId");
        }
    }
}
