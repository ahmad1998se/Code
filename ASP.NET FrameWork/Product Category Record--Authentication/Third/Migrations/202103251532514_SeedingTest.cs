namespace Third.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingTest : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Roles(Title) VALUES('Administrator')");
            Sql("INSERT INTO Roles(Title) VALUES('Power User')");
            Sql("INSERT INTO Roles(Title) VALUES('User')");
            Sql("INSERT INTO Roles(Title) VALUES('Client')");
        }
        
        public override void Down()
        {
        }
    }
}
