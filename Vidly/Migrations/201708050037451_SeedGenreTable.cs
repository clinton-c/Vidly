namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");

            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action/Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Suspense')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Romantic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Classic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Kids')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Sci-fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
