namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitiationDB1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PostTags", name: "ProductID", newName: "PostID");
            RenameIndex(table: "dbo.PostTags", name: "IX_ProductID", newName: "IX_PostID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PostTags", name: "IX_PostID", newName: "IX_ProductID");
            RenameColumn(table: "dbo.PostTags", name: "PostID", newName: "ProductID");
        }
    }
}
