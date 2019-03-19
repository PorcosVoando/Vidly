namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate,Name) Values(1,0,0,0,'Pay as You Go')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate,Name) Values(2,30,1,10,'Monthly')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate,Name) Values(3,90,3,15,Quarterly')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonth, DiscountRate,Name) Values(4,300,12,20,'anual')");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
