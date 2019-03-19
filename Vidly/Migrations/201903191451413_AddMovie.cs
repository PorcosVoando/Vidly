namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(nullable: false),
                    Genre = c.String(nullable: false),
                    ReleaseDate = c.DateTime(nullable: true),
                    DateAdded = c.DateTime(nullable: true),
                    NumberInStock = c.Int(nullable: false),
                });
        }
        
        public override void Down()
        {
        }
    }
}
