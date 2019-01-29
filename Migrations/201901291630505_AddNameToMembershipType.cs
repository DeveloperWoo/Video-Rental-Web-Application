namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false)); //allow null value
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
