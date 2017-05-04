namespace SCCPetsMVC.DataContexts.PetMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PetName = c.String(nullable: false, maxLength: 15),
                        Breed = c.String(nullable: false),
                        IsFixed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pets");
        }
    }
}
