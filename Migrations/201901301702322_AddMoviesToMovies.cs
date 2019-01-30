namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 5, CAST('2009-11-6' AS DATETIME), CAST('2019-01-30' AS DATETIME), 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story3', 3, CAST('2010-06-18' AS DATETIME), CAST('2019-01-30' AS DATETIME), 4)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, CAST('1997-11-18' AS DATETIME), CAST('2019-01-30' AS DATETIME), 3)");
        }
        
        public override void Down()
        {
        }
    }
}
