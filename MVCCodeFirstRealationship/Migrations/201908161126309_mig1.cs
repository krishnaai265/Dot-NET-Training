namespace MVCCodeFirstRealationship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.Int(nullable: false),
                        AuthorAge = c.Int(nullable: false),
                        AuthorDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
