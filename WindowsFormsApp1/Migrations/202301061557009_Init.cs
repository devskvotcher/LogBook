namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        PatientSurname = c.String(maxLength: 50),
                        PatientName = c.String(maxLength: 50),
                        PatientSecondName = c.String(maxLength: 50),
                        PatientMedicalHistoryID = c.Int(nullable: false),
                        PatientAge = c.Int(nullable: false),
                        PatientDeliveri = c.DateTime(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        PatientTransferTime = c.DateTime(nullable: false),
                        PatientResultID = c.Int(nullable: false),
                        PatientTimeOfHospitalization = c.Int(nullable: false),
                        COVID19 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.PatientResults", t => t.PatientResultID, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.PatientResultID);
            
            CreateTable(
                "dbo.PatientResults",
                c => new
                    {
                        PatientResultID = c.Int(nullable: false, identity: true),
                        PatientResultName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PatientResultID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Patients", "PatientResultID", "dbo.PatientResults");
            DropIndex("dbo.Patients", new[] { "PatientResultID" });
            DropIndex("dbo.Patients", new[] { "DepartmentID" });
            DropTable("dbo.PatientResults");
            DropTable("dbo.Patients");
            DropTable("dbo.Departments");
        }
    }
}
