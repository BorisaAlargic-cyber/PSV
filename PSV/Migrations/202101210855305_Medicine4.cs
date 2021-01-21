namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Medicine4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Termins", "Doctor_Id", "dbo.Users");
            DropForeignKey("dbo.Apointments", "Termin_Id", "dbo.Termins");
            DropIndex("dbo.Apointments", new[] { "Termin_Id" });
            DropIndex("dbo.Termins", new[] { "Doctor_Id" });
            AddColumn("dbo.Apointments", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Apointments", "Taken", c => c.Boolean(nullable: false));
            AddColumn("dbo.Apointments", "Comment", c => c.String());
            AddColumn("dbo.Apointments", "Doctor_Id", c => c.Int());
            CreateIndex("dbo.Apointments", "Doctor_Id");
            AddForeignKey("dbo.Apointments", "Doctor_Id", "dbo.Users", "Id");
            DropColumn("dbo.Apointments", "Termin_Id");
            DropTable("dbo.Termins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Termins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Taken = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Doctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Apointments", "Termin_Id", c => c.Int());
            DropForeignKey("dbo.Apointments", "Doctor_Id", "dbo.Users");
            DropIndex("dbo.Apointments", new[] { "Doctor_Id" });
            DropColumn("dbo.Apointments", "Doctor_Id");
            DropColumn("dbo.Apointments", "Comment");
            DropColumn("dbo.Apointments", "Taken");
            DropColumn("dbo.Apointments", "Date");
            CreateIndex("dbo.Termins", "Doctor_Id");
            CreateIndex("dbo.Apointments", "Termin_Id");
            AddForeignKey("dbo.Apointments", "Termin_Id", "dbo.Termins", "Id");
            AddForeignKey("dbo.Termins", "Doctor_Id", "dbo.Users", "Id");
        }
    }
}
