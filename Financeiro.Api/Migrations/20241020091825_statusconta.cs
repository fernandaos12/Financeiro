using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class statusconta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_TAG_ID",
                table: "TB_TAGS");

            migrationBuilder.DropIndex(
                name: "IX_TB_TAGS_TAG_ID",
                table: "TB_TAGS");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "TB_TAGS",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ID_CONTAPAGAR",
                table: "TB_TAGS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_CONTAPAGAR",
                table: "TB_PAGAMENTO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STATUS_CONTA",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_CONTAPAGAR",
                table: "TB_CATEGORIAS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID_CONTAPAGAR",
                table: "TB_TAGS",
                column: "ID_CONTAPAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PAGAMENTO_ID_CONTAPAGAR",
                table: "TB_PAGAMENTO",
                column: "ID_CONTAPAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CATEGORIAS_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS",
                column: "ID_CONTAPAGAR");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CATEGORIAS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS",
                column: "ID_CONTAPAGAR",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PAGAMENTO_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_PAGAMENTO",
                column: "ID_CONTAPAGAR",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID",
                table: "TB_TAGS",
                column: "ID",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_TAGS",
                column: "ID_CONTAPAGAR",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CATEGORIAS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PAGAMENTO_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID",
                table: "TB_TAGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_TAGS");

            migrationBuilder.DropIndex(
                name: "IX_TB_TAGS_ID_CONTAPAGAR",
                table: "TB_TAGS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PAGAMENTO_ID_CONTAPAGAR",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_CATEGORIAS_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS");

            migrationBuilder.DropColumn(
                name: "ID_CONTAPAGAR",
                table: "TB_TAGS");

            migrationBuilder.DropColumn(
                name: "ID_CONTAPAGAR",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropColumn(
                name: "STATUS_CONTA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "ID_CONTAPAGAR",
                table: "TB_CATEGORIAS");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "TB_TAGS",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_TAG_ID",
                table: "TB_TAGS",
                column: "TAG_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_TAG_ID",
                table: "TB_TAGS",
                column: "TAG_ID",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");
        }
    }
}
