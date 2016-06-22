namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRequiresValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "FirstName", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "FirstName", c => c.String(nullable: false));
        }
    }
}
