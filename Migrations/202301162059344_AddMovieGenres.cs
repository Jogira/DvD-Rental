namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
