namespace GuildBlog.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordstuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Postings", "IsApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Postings", "IsApproved");
        }
    }
}
