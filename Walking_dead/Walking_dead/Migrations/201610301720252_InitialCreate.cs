namespace Walking_dead.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        EpisodeID = c.Int(nullable: false, identity: true),
                        Season = c.Int(nullable: false),
                        Episodes = c.Int(nullable: false),
                        Title = c.String(),
                        Date_Aired = c.String(),
                        Plot = c.String(),
                        Review = c.String(),
                        Complete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EpisodeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Episodes");
        }
    }
}
