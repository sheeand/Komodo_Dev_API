namespace Komodo_Dev_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        DevId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContractId);
            
            CreateTable(
                "dbo.Devs",
                c => new
                    {
                        DevId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        HireDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ProficiencyLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DevId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
            DropTable("dbo.Devs");
            DropTable("dbo.Contracts");
        }
    }
}
