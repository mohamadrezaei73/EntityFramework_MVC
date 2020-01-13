namespace EntityFramework_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intializer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LastName", c => c.String());
            DropColumn("dbo.People", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "FullName", c => c.String());
            DropColumn("dbo.People", "LastName");
        }
    }
}
