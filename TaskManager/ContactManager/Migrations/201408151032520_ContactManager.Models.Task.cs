namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactManagerModelsTask : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "StartDate");
            DropColumn("dbo.Tasks", "CompleteDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "CompleteDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
