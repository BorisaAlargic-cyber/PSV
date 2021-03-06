﻿namespace PSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Medicine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recepies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recepies");
            DropTable("dbo.Drugs");
        }
    }
}
