namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwoNewGeneres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");

            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Western')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
