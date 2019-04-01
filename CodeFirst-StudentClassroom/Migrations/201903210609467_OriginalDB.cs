namespace CodeFirst_StudentClassroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ClassroomID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        ClassroomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomID, cascadeDelete: true)
                .Index(t => t.ClassroomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassroomID", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "ClassroomID" });
            DropTable("dbo.Students");
            DropTable("dbo.Classrooms");
        }
    }
}
