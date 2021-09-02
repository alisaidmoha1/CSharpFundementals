namespace GeneralStoreApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerDateJoin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateJoined", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateJoined");
        }
    }
}
