namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedImageBinaryFromModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ImageId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "ImageName", c => c.String());
            DropColumn("dbo.Movies", "PosterBinary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "PosterBinary", c => c.Binary(maxLength: 8000));
            DropColumn("dbo.Movies", "ImageName");
            DropColumn("dbo.Movies", "ImageId");
        }
    }
}
