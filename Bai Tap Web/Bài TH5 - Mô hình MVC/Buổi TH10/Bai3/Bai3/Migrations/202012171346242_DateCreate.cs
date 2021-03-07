namespace Bai3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "DateCreate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "DateCreate");
        }
    }
}
