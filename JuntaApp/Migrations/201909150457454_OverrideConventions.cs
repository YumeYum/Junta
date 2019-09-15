namespace JuntaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Juntas", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Juntas", "Organizador_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Juntas", new[] { "Categoria_Id" });
            DropIndex("dbo.Juntas", new[] { "Organizador_Id" });
            AlterColumn("dbo.Categorias", "Nombre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Juntas", "Lugar", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Juntas", "Categoria_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Juntas", "Organizador_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Juntas", "Categoria_Id");
            CreateIndex("dbo.Juntas", "Organizador_Id");
            AddForeignKey("dbo.Juntas", "Categoria_Id", "dbo.Categorias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Juntas", "Organizador_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Juntas", "Organizador_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Juntas", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Juntas", new[] { "Organizador_Id" });
            DropIndex("dbo.Juntas", new[] { "Categoria_Id" });
            AlterColumn("dbo.Juntas", "Organizador_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Juntas", "Categoria_Id", c => c.Byte());
            AlterColumn("dbo.Juntas", "Lugar", c => c.String());
            AlterColumn("dbo.Categorias", "Nombre", c => c.String());
            CreateIndex("dbo.Juntas", "Organizador_Id");
            CreateIndex("dbo.Juntas", "Categoria_Id");
            AddForeignKey("dbo.Juntas", "Organizador_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Juntas", "Categoria_Id", "dbo.Categorias", "Id");
        }
    }
}
