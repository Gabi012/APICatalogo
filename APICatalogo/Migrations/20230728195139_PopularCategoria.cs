using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categoria (Nome, ImagemUrl) values ('Bebidas', 'bebidas.jgp')");
            mb.Sql("INSERT INTO Categoria  (Nome, ImagemUrl) values ('Lanches', 'lanches.jgp')");
            mb.Sql("INSERT INTO Categoria  (Nome, ImagemUrl) values ('Sobremesas', 'sobremesa.jgp')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Categoria");
        }
    }
}
