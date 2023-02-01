namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviePosterToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PosterBinary", c => c.Binary(maxLength: 8000));
            AddColumn("dbo.Movies", "ImagePath", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImagePath");
            DropColumn("dbo.Movies", "PosterBinary");
        }
    }
}
