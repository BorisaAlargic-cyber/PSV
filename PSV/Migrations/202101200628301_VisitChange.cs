namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VisitChange : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Visits", new[] { "apointment_Id" });
            CreateIndex("dbo.Visits", "Apointment_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Visits", new[] { "Apointment_Id" });
            CreateIndex("dbo.Visits", "apointment_Id");
        }
    }
}
