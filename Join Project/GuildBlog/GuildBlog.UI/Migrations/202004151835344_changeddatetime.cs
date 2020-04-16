namespace GuildBlog.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeddatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Postings", "PostingDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Postings", "PostingDate", c => c.DateTime(nullable: false));
        }
    }
}
