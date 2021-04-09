namespace Third.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategory : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String(maxLength: 50));
        }
    }
}
