using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.API.Migrations
{
    /// <inheritdoc />
    public partial class livros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadePaginas = table.Column<int>(type: "int", nullable: false),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_lancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Livro", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Livro");
        }
    }
}
