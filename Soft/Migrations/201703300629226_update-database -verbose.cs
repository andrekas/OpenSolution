namespace Soft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabaseverbose : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoleandParties", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoleandParties", "Address");
        }
    }
}
