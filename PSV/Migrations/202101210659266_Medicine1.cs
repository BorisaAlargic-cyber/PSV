namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Medicine1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drugs", "Name", c => c.String());
            AddColumn("dbo.Recepies", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Recepies", "Doctor_Id", c => c.Int());
            AddColumn("dbo.Recepies", "Drug_Id", c => c.Int());
            AddColumn("dbo.Recepies", "Pacient_Id", c => c.Int());
            CreateIndex("dbo.Recepies", "Doctor_Id");
            CreateIndex("dbo.Recepies", "Drug_Id");
            CreateIndex("dbo.Recepies", "Pacient_Id");
            AddForeignKey("dbo.Recepies", "Doctor_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Recepies", "Drug_Id", "dbo.Drugs", "Id");
            AddForeignKey("dbo.Recepies", "Pacient_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recepies", "Pacient_Id", "dbo.Users");
            DropForeignKey("dbo.Recepies", "Drug_Id", "dbo.Drugs");
            DropForeignKey("dbo.Recepies", "Doctor_Id", "dbo.Users");
            DropIndex("dbo.Recepies", new[] { "Pacient_Id" });
            DropIndex("dbo.Recepies", new[] { "Drug_Id" });
            DropIndex("dbo.Recepies", new[] { "Doctor_Id" });
            DropColumn("dbo.Recepies", "Pacient_Id");
            DropColumn("dbo.Recepies", "Drug_Id");
            DropColumn("dbo.Recepies", "Doctor_Id");
            DropColumn("dbo.Recepies", "Quantity");
            DropColumn("dbo.Drugs", "Name");
        }
    }
}
