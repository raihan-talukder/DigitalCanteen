namespace DigitalCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountDetails",
                c => new
                    {
                        AccounNumber = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        InitialBalance = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        Refil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccounNumber)
                .ForeignKey("dbo.UserDetails", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.String(),
                        UseId = c.Int(nullable: false),
                        AccountDetail_AccounNumber = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.AccountDetails", t => t.AccountDetail_AccounNumber)
                .Index(t => t.AccountDetail_AccounNumber);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserCredentials",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserDetails", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountDetails", "UserId", "dbo.UserDetails");
            DropForeignKey("dbo.UserCredentials", "UserId", "dbo.UserDetails");
            DropForeignKey("dbo.Items", "AccountDetail_AccounNumber", "dbo.AccountDetails");
            DropIndex("dbo.AccountDetails", new[] { "UserId" });
            DropIndex("dbo.UserCredentials", new[] { "UserId" });
            DropIndex("dbo.Items", new[] { "AccountDetail_AccounNumber" });
            DropTable("dbo.UserCredentials");
            DropTable("dbo.UserDetails");
            DropTable("dbo.Items");
            DropTable("dbo.AccountDetails");
        }
    }
}
