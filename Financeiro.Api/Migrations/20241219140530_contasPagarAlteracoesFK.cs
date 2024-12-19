using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class contasPagarAlteracoesFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.AddColumn<int>(
                name: "CATEGORIAID",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_CATEGORIAID",
                table: "TB_CONTAS_PAGAR",
                column: "CATEGORIAID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_CATEGORIAID",
                table: "TB_CONTAS_PAGAR",
                column: "CATEGORIAID",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_CATEGORIAID",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_CATEGORIAID",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "CATEGORIAID",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                column: "ID_CATEGORIA");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                column: "ID_CATEGORIA",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID");
        }
    }
}
