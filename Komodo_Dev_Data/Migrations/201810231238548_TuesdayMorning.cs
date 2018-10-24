namespace Komodo_Dev_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TuesdayMorning : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contract", newName: "ContractData");
            RenameTable(name: "dbo.Dev", newName: "DevData");
            RenameTable(name: "dbo.Team", newName: "TeamData");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TeamData", newName: "Team");
            RenameTable(name: "dbo.DevData", newName: "Dev");
            RenameTable(name: "dbo.ContractData", newName: "Contract");
        }
    }
}
