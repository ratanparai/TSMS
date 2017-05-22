namespace TSMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requirements : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "Department_ID" });
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "Department_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "Department_ID");
            AddForeignKey("dbo.Teachers", "Department_ID", "dbo.Departments", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "Department_ID" });
            AlterColumn("dbo.Teachers", "Department_ID", c => c.Int());
            AlterColumn("dbo.Teachers", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
            CreateIndex("dbo.Teachers", "Department_ID");
            AddForeignKey("dbo.Teachers", "Department_ID", "dbo.Departments", "ID");
        }
    }
}
