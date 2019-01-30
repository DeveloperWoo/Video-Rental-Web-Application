namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 255),
                    GenreId = c.Byte(nullable: false),
                    DateAdded = c.DateTime(nullable: false),
                    ReleaseDate = c.DateTime(nullable: false),
                    NumberInStock = c.Byte(nullable: false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", testc => testc.GenreId, cascadeDelete: true)
                .Index(testc => testc.GenreId);

        }

        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
