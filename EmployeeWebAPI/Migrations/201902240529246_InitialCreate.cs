namespace EmployeeWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        IsWorking = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
        
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
