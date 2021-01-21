namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Medicine2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drugs", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drugs", "Quantity");
        }
    }
}
