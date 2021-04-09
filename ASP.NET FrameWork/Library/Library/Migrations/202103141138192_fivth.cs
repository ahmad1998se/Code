namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fivth : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 0, 0 ,0)");
            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (5, 30, 1 ,10)");
            Sql("SET IDENTITY_INSERT MembershipTypes ON INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (6, 90, 3 ,15)");
        }
        
        public override void Down()
        {
        }
    }
}
