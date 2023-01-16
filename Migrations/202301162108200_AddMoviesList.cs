namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Iron Giant', 4, 16-1-23, 11-9-1998, 10, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES ('Spirited Away', 4, 16-1-23, 10-12-1998, 3, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
