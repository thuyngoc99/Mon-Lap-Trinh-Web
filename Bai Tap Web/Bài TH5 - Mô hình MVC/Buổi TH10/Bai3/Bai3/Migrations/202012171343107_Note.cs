namespace Bai3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Note : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Note", c => c.String());
            //AddColumn("dbo.Categories", "DateCreate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Categories", "DateCreate");
            DropColumn("dbo.Categories", "Note");
        }
    }
}
