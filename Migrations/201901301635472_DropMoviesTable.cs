namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("DROP TABLE Movies");
        }
        
        public override void Down()
        {
        }
    }
}
