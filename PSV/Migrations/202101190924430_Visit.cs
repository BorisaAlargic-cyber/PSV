namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Visit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        results = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        apointment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apointments", t => t.apointment_Id)
                .Index(t => t.apointment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "apointment_Id", "dbo.Apointments");
            DropIndex("dbo.Visits", new[] { "apointment_Id" });
            DropTable("dbo.Visits");
        }
    }
}
