namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Patients_PatientID", "dbo.Patients");
            DropForeignKey("dbo.PatientResults", "Patients_PatientID", "dbo.Patients");
            DropIndex("dbo.Departments", new[] { "Patients_PatientID" });
            DropIndex("dbo.PatientResults", new[] { "Patients_PatientID" });
            RenameColumn(table: "dbo.Departments", name: "DepartmentsID_DepartmentID", newName: "Department_DepartmentID");
            RenameIndex(table: "dbo.Departments", name: "IX_DepartmentsID_DepartmentID", newName: "IX_Department_DepartmentID");
            AddColumn("dbo.PatientResults", "PatientResult_PatientResultID", c => c.Int());
            AddColumn("dbo.Patients", "Patients_PatientID", c => c.Int());
            CreateIndex("dbo.PatientResults", "PatientResult_PatientResultID");
            CreateIndex("dbo.Patients", "Patients_PatientID");
            AddForeignKey("dbo.PatientResults", "PatientResult_PatientResultID", "dbo.PatientResults", "PatientResultID");
            AddForeignKey("dbo.Patients", "Patients_PatientID", "dbo.Patients", "PatientID");
            DropColumn("dbo.Departments", "Patients_PatientID");
            DropColumn("dbo.PatientResults", "Patients_PatientID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientResults", "Patients_PatientID", c => c.Int());
            AddColumn("dbo.Departments", "Patients_PatientID", c => c.Int());
            DropForeignKey("dbo.Patients", "Patients_PatientID", "dbo.Patients");
            DropForeignKey("dbo.PatientResults", "PatientResult_PatientResultID", "dbo.PatientResults");
            DropIndex("dbo.Patients", new[] { "Patients_PatientID" });
            DropIndex("dbo.PatientResults", new[] { "PatientResult_PatientResultID" });
            DropColumn("dbo.Patients", "Patients_PatientID");
            DropColumn("dbo.PatientResults", "PatientResult_PatientResultID");
            RenameIndex(table: "dbo.Departments", name: "IX_Department_DepartmentID", newName: "IX_DepartmentsID_DepartmentID");
            RenameColumn(table: "dbo.Departments", name: "Department_DepartmentID", newName: "DepartmentsID_DepartmentID");
            CreateIndex("dbo.PatientResults", "Patients_PatientID");
            CreateIndex("dbo.Departments", "Patients_PatientID");
            AddForeignKey("dbo.PatientResults", "Patients_PatientID", "dbo.Patients", "PatientID");
            AddForeignKey("dbo.Departments", "Patients_PatientID", "dbo.Patients", "PatientID");
        }
    }
}
