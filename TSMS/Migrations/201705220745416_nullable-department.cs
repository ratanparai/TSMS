namespace TSMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullabledepartment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            AlterColumn("dbo.Teachers", "DepartmentID", c => c.Int());
            CreateIndex("dbo.Teachers", "DepartmentID");
            AddForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            AlterColumn("dbo.Teachers", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "DepartmentID");
            AddForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments", "ID", cascadeDelete: true);
        }
    }
}
