namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalMigrationForOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 160));
        }
    }
}
