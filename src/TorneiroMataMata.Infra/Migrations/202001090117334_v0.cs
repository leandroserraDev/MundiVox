namespace TorneiroMataMata.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        GrupoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.GrupoId);
            
            CreateTable(
                "dbo.Time",
                c => new
                    {
                        TimeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Gol = c.Int(nullable: false),
                        SaldoGols = c.Int(nullable: false),
                        GrupoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TimeId)
                .ForeignKey("dbo.Grupo", t => t.GrupoId)
                .Index(t => t.GrupoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Time", "GrupoId", "dbo.Grupo");
            DropIndex("dbo.Time", new[] { "GrupoId" });
            DropTable("dbo.Time");
            DropTable("dbo.Grupo");
        }
    }
}
