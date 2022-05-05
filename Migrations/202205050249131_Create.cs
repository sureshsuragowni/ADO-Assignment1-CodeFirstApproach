﻿namespace FootBallCodeFirstAppr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootBalls",
                c => new
                    {
                        MatchID = c.Int(nullable: false),
                        TeamName1 = c.String(),
                        TeamName2 = c.String(),
                        Status = c.String(),
                        WinningTeam = c.String(),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FootBalls");
        }
    }
}
