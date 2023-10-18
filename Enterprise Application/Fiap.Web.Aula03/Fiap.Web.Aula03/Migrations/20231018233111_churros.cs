using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.Aula03.Migrations
{
    /// <inheritdoc />
    public partial class churros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoraId",
                table: "Tb_Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tb_Atores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nacionalidade = table.Column<int>(type: "int", nullable: false),
                    Premiado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Atores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRESIDENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRESIDENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_FILME_ATOR",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false),
                    AtorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILME_ATOR", x => new { x.FilmeId, x.AtorId });
                    table.ForeignKey(
                        name: "FK_TB_FILME_ATOR_Tb_Atores_AtorId",
                        column: x => x.AtorId,
                        principalTable: "Tb_Atores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FILME_ATOR_Tb_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Tb_Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTORA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Premios = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    PresidenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTORA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTORA_TB_PRESIDENTE_PresidenteId",
                        column: x => x.PresidenteId,
                        principalTable: "TB_PRESIDENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Filme_ProdutoraId",
                table: "Tb_Filme",
                column: "ProdutoraId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILME_ATOR_AtorId",
                table: "TB_FILME_ATOR",
                column: "AtorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTORA_PresidenteId",
                table: "TB_PRODUTORA",
                column: "PresidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Filme_TB_PRODUTORA_ProdutoraId",
                table: "Tb_Filme",
                column: "ProdutoraId",
                principalTable: "TB_PRODUTORA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Filme_TB_PRODUTORA_ProdutoraId",
                table: "Tb_Filme");

            migrationBuilder.DropTable(
                name: "TB_FILME_ATOR");

            migrationBuilder.DropTable(
                name: "TB_PRODUTORA");

            migrationBuilder.DropTable(
                name: "Tb_Atores");

            migrationBuilder.DropTable(
                name: "TB_PRESIDENTE");

            migrationBuilder.DropIndex(
                name: "IX_Tb_Filme_ProdutoraId",
                table: "Tb_Filme");

            migrationBuilder.DropColumn(
                name: "ProdutoraId",
                table: "Tb_Filme");
        }
    }
}
