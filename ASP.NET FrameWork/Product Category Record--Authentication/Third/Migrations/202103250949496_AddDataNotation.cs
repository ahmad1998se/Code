﻿namespace Third.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataNotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Category", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Description", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
