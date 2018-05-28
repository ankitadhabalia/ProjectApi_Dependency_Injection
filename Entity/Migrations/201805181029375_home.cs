namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class home : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Mail = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
