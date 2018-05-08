namespace InternPortal.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        OptionId = c.Int(),
                        AnswerValue = c.String(unicode: false),
                        OptionValue = c.Boolean(),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Application", t => t.ApplicationId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .ForeignKey("dbo.QuestionOptions", t => t.OptionId)
                .Index(t => t.ApplicationId)
                .Index(t => t.QuestionId)
                .Index(t => t.OptionId);
            
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ApplicationStartDate = c.DateTime(),
                        ApplicationCompleteDate = c.DateTime(),
                        ApplicationStatus = c.Int(),
                    })
                .PrimaryKey(t => t.ApplicationId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 100),
                        MiddleName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        PhoneNumber = c.String(maxLength: 50),
                        Address = c.String(),
                        City = c.String(maxLength: 100),
                        State = c.String(maxLength: 100),
                        ZipCode = c.String(maxLength: 10),
                        DateOfBirth = c.DateTime(storeType: "date"),
                        Gender = c.String(maxLength: 50),
                        Ethnicity = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        UserIdFrom = c.Int(nullable: false),
                        UserIdTo = c.Int(nullable: false),
                        MessageSubject = c.String(),
                        MessageBody = c.String(),
                        DateTimeSent = c.DateTime(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.User", t => t.UserIdFrom)
                .ForeignKey("dbo.User", t => t.UserIdTo)
                .Index(t => t.UserIdFrom)
                .Index(t => t.UserIdTo);
            
            CreateTable(
                "dbo.UserUploads",
                c => new
                    {
                        UploadId = c.Int(nullable: false),
                        UserId = c.Int(),
                        ApplicationId = c.Int(),
                        UploadLocation = c.String(),
                        UploadTitle = c.String(),
                        UploadDescription = c.String(),
                    })
                .PrimaryKey(t => t.UploadId)
                .ForeignKey("dbo.Application", t => t.ApplicationId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionTypeId = c.Int(nullable: false),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.QuestionTypes", t => t.QuestionTypeId)
                .Index(t => t.QuestionTypeId);
            
            CreateTable(
                "dbo.QuestionOptions",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        OptionValue = c.String(),
                    })
                .PrimaryKey(t => t.OptionId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        QuestionTypeId = c.Int(nullable: false),
                        QuestionType = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.QuestionTypeId);
            
            CreateTable(
                "dbo.ApplicationStatus",
                c => new
                    {
                        ApplicationStatusId = c.Int(nullable: false),
                        Status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ApplicationStatusId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "OptionId", "dbo.QuestionOptions");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Question", "QuestionTypeId", "dbo.QuestionTypes");
            DropForeignKey("dbo.QuestionOptions", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Answers", "ApplicationId", "dbo.Application");
            DropForeignKey("dbo.Application", "UserId", "dbo.User");
            DropForeignKey("dbo.UserUploads", "UserId", "dbo.User");
            DropForeignKey("dbo.UserUploads", "ApplicationId", "dbo.Application");
            DropForeignKey("dbo.Messages", "UserIdTo", "dbo.User");
            DropForeignKey("dbo.Messages", "UserIdFrom", "dbo.User");
            DropForeignKey("dbo.User", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.QuestionOptions", new[] { "QuestionId" });
            DropIndex("dbo.Question", new[] { "QuestionTypeId" });
            DropIndex("dbo.UserUploads", new[] { "ApplicationId" });
            DropIndex("dbo.UserUploads", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "UserIdTo" });
            DropIndex("dbo.Messages", new[] { "UserIdFrom" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "Id" });
            DropIndex("dbo.Application", new[] { "UserId" });
            DropIndex("dbo.Answers", new[] { "OptionId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Answers", new[] { "ApplicationId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.ApplicationStatus");
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.QuestionOptions");
            DropTable("dbo.Question");
            DropTable("dbo.UserUploads");
            DropTable("dbo.Messages");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.User");
            DropTable("dbo.Application");
            DropTable("dbo.Answers");
        }
    }
}