namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {


            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0 ,0)");
            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1 ,10)");
            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3 ,15)");
        }
        
        public override void Down()
        {
        }
    }
}
