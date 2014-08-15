namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        IsComplete = c.Boolean(nullable: false)
                        
                    })
                .PrimaryKey(t => t.TaskID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
