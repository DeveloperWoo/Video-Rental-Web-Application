namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateToCustomer11 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
