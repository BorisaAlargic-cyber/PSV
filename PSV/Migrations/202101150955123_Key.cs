namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Key : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deleted = c.Boolean(nullable: false),
                        Patient_Id = c.Int(),
                        Termin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .ForeignKey("dbo.Termins", t => t.Termin_Id)
                .Index(t => t.Patient_Id)
                .Index(t => t.Termin_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role = c.String(),
                        Speciality = c.String(),
                        FirstTime = c.Boolean(nullable: false),
                        Blocked = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        ChoosenDoctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ChoosenDoctor_Id)
                .Index(t => t.ChoosenDoctor_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Doctor_Id)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        Published = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.Instructions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Speciality = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructions", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.Apointments", "Termin_Id", "dbo.Termins");
            DropForeignKey("dbo.Termins", "Doctor_Id", "dbo.Users");
            DropForeignKey("dbo.Apointments", "Patient_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "ChoosenDoctor_Id", "dbo.Users");
            DropIndex("dbo.Instructions", new[] { "Patient_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Patient_Id" });
            DropIndex("dbo.Termins", new[] { "Doctor_Id" });
            DropIndex("dbo.Users", new[] { "ChoosenDoctor_Id" });
            DropIndex("dbo.Apointments", new[] { "Termin_Id" });
            DropIndex("dbo.Apointments", new[] { "Patient_Id" });
            DropTable("dbo.Instructions");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Termins");
            DropTable("dbo.Users");
            DropTable("dbo.Apointments");
        }
    }
}
