namespace GuildBlog.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postingdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Postings", "PostingDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Postings", "PostingDate");
        }
    }
}
