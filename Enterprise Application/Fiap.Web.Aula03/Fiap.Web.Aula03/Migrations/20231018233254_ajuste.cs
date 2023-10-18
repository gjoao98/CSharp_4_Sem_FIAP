using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.Aula03.Migrations
{
    /// <inheritdoc />
    public partial class ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Filme_TB_PRODUTORA_ProdutoraId",
                table: "Tb_Filme");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_FILME_ATOR_Tb_Atores_AtorId",
                table: "TB_FILME_ATOR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_FILME_ATOR_Tb_Filme_FilmeId",
                table: "TB_FILME_ATOR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUTORA_TB_PRESIDENTE_PresidenteId",
                table: "TB_PRODUTORA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRODUTORA",
                table: "TB_PRODUTORA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRESIDENTE",
                table: "TB_PRESIDENTE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_FILME_ATOR",
                table: "TB_FILME_ATOR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Atores",
                table: "Tb_Atores");

            migrationBuilder.RenameTable(
                name: "TB_PRODUTORA",
                newName: "Tb_Produtora");

            migrationBuilder.RenameTable(
                name: "TB_PRESIDENTE",
                newName: "Tb_Presidente");

            migrationBuilder.RenameTable(
                name: "TB_FILME_ATOR",
                newName: "Tb_Filme_Ator");

            migrationBuilder.RenameTable(
                name: "Tb_Atores",
                newName: "Tb_Ator");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUTORA_PresidenteId",
                table: "Tb_Produtora",
                newName: "IX_Tb_Produtora_PresidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_FILME_ATOR_AtorId",
                table: "Tb_Filme_Ator",
                newName: "IX_Tb_Filme_Ator_AtorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Produtora",
                table: "Tb_Produtora",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Presidente",
                table: "Tb_Presidente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Filme_Ator",
                table: "Tb_Filme_Ator",
                columns: new[] { "FilmeId", "AtorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Ator",
                table: "Tb_Ator",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Filme_Tb_Produtora_ProdutoraId",
                table: "Tb_Filme",
                column: "ProdutoraId",
                principalTable: "Tb_Produtora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Filme_Ator_Tb_Ator_AtorId",
                table: "Tb_Filme_Ator",
                column: "AtorId",
                principalTable: "Tb_Ator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Filme_Ator_Tb_Filme_FilmeId",
                table: "Tb_Filme_Ator",
                column: "FilmeId",
                principalTable: "Tb_Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Produtora_Tb_Presidente_PresidenteId",
                table: "Tb_Produtora",
                column: "PresidenteId",
                principalTable: "Tb_Presidente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Filme_Tb_Produtora_ProdutoraId",
                table: "Tb_Filme");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Filme_Ator_Tb_Ator_AtorId",
                table: "Tb_Filme_Ator");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Filme_Ator_Tb_Filme_FilmeId",
                table: "Tb_Filme_Ator");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_Produtora_Tb_Presidente_PresidenteId",
                table: "Tb_Produtora");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Produtora",
                table: "Tb_Produtora");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Presidente",
                table: "Tb_Presidente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Filme_Ator",
                table: "Tb_Filme_Ator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Ator",
                table: "Tb_Ator");

            migrationBuilder.RenameTable(
                name: "Tb_Produtora",
                newName: "TB_PRODUTORA");

            migrationBuilder.RenameTable(
                name: "Tb_Presidente",
                newName: "TB_PRESIDENTE");

            migrationBuilder.RenameTable(
                name: "Tb_Filme_Ator",
                newName: "TB_FILME_ATOR");

            migrationBuilder.RenameTable(
                name: "Tb_Ator",
                newName: "Tb_Atores");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_Produtora_PresidenteId",
                table: "TB_PRODUTORA",
                newName: "IX_TB_PRODUTORA_PresidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_Filme_Ator_AtorId",
                table: "TB_FILME_ATOR",
                newName: "IX_TB_FILME_ATOR_AtorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRODUTORA",
                table: "TB_PRODUTORA",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRESIDENTE",
                table: "TB_PRESIDENTE",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_FILME_ATOR",
                table: "TB_FILME_ATOR",
                columns: new[] { "FilmeId", "AtorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Atores",
                table: "Tb_Atores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_Filme_TB_PRODUTORA_ProdutoraId",
                table: "Tb_Filme",
                column: "ProdutoraId",
                principalTable: "TB_PRODUTORA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_FILME_ATOR_Tb_Atores_AtorId",
                table: "TB_FILME_ATOR",
                column: "AtorId",
                principalTable: "Tb_Atores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_FILME_ATOR_Tb_Filme_FilmeId",
                table: "TB_FILME_ATOR",
                column: "FilmeId",
                principalTable: "Tb_Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUTORA_TB_PRESIDENTE_PresidenteId",
                table: "TB_PRODUTORA",
                column: "PresidenteId",
                principalTable: "TB_PRESIDENTE",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
