namespace JuntaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearTablaJunta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Juntas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Lugar = c.String(),
                        Categoria_Id = c.Byte(),
                        Organizador_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Organizador_Id)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Organizador_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Juntas", "Organizador_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Juntas", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Juntas", new[] { "Organizador_Id" });
            DropIndex("dbo.Juntas", new[] { "Categoria_Id" });
            DropTable("dbo.Juntas");
            DropTable("dbo.Categorias");
        }
    }
}
