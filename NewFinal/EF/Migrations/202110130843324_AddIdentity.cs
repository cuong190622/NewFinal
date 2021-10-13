namespace NewFinal.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Category = c.String(),
                        Description = c.String(),
                        CourseCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourseCategory", t => t.CourseCategory_Id)
                .Index(t => t.CourseCategory_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Education = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        DoB = c.DateTime(nullable: false),
                        ProgrammingLanguage = c.String(),
                        Toeic = c.Single(nullable: false),
                        Experience = c.String(),
                        Department = c.String(),
                        Location = c.String(),
                        Type = c.String(),
                        WorkingPlace = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        CourseAssignId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserEntityCourseEntities",
                c => new
                    {
                        UserEntity_Id = c.Int(nullable: false),
                        CourseEntity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserEntity_Id, t.CourseEntity_Id })
                .ForeignKey("dbo.Users", t => t.UserEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.CourseEntity_Id, cascadeDelete: true)
                .Index(t => t.UserEntity_Id)
                .Index(t => t.CourseEntity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEntityCourseEntities", "CourseEntity_Id", "dbo.Course");
            DropForeignKey("dbo.UserEntityCourseEntities", "UserEntity_Id", "dbo.Users");
            DropForeignKey("dbo.Course", "CourseCategory_Id", "dbo.CourseCategory");
            DropIndex("dbo.UserEntityCourseEntities", new[] { "CourseEntity_Id" });
            DropIndex("dbo.UserEntityCourseEntities", new[] { "UserEntity_Id" });
            DropIndex("dbo.Course", new[] { "CourseCategory_Id" });
            DropTable("dbo.UserEntityCourseEntities");
            DropTable("dbo.Users");
            DropTable("dbo.Course");
            DropTable("dbo.CourseCategory");
        }
    }
}
