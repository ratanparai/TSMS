namespace TSMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddepartmentID : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Teachers", name: "Department_ID", newName: "DepartmentID");
            RenameIndex(table: "dbo.Teachers", name: "IX_Department_ID", newName: "IX_DepartmentID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Teachers", name: "IX_DepartmentID", newName: "IX_Department_ID");
            RenameColumn(table: "dbo.Teachers", name: "DepartmentID", newName: "Department_ID");
        }
    }
}
