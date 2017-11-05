namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserPhoneNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNum", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhoneNum");
        }
    }
}
