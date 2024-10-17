using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class correcaoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID1",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID1",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_COBRANCA_TB_NEGOCIACAO_ID1",
                table: "TB_COBRANCA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_COBRANCA_TB_PAGAMENTO_ID1",
                table: "TB_COBRANCA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID1",
                table: "TB_CONTA_BANCARIA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID1",
                table: "TB_NEGOCIACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID1",
                table: "TB_RECEITAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID1",
                table: "TB_TAGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID1",
                table: "TB_TAGS");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_TAGS",
                newName: "TAG_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_TAGS_ID1",
                table: "TB_TAGS",
                newName: "IX_TB_TAGS_TAG_ID");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_RECEITAS",
                newName: "ID_RECEITAS");

            migrationBuilder.RenameIndex(
                name: "IX_TB_RECEITAS_ID1",
                table: "TB_RECEITAS",
                newName: "IX_TB_RECEITAS_ID_RECEITAS");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_NEGOCIACAO",
                newName: "ID_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "CATEGORIA",
                table: "TB_NEGOCIACAO",
                newName: "ID_CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_NEGOCIACAO_ID1",
                table: "TB_NEGOCIACAO",
                newName: "IX_TB_NEGOCIACAO_ID_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_CONTAS_PAGAR",
                newName: "ID_PAGAMENTO");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_PAGAR_ID1",
                table: "TB_CONTAS_PAGAR",
                newName: "IX_TB_CONTAS_PAGAR_ID_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_CONTA_BANCARIA",
                newName: "ID_CONTA_BANCARIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTA_BANCARIA_ID1",
                table: "TB_CONTA_BANCARIA",
                newName: "IX_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_COBRANCA",
                newName: "ID_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "CATEGORIA",
                table: "TB_COBRANCA",
                newName: "ID_CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_COBRANCA_ID1",
                table: "TB_COBRANCA",
                newName: "IX_TB_COBRANCA_ID_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "ID1",
                table: "TB_CARTAO_CREDITO",
                newName: "ID_CONTA_BANCARIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CARTAO_CREDITO_ID1",
                table: "TB_CARTAO_CREDITO",
                newName: "IX_TB_CARTAO_CREDITO_ID_CONTA_BANCARIA");

            migrationBuilder.AddColumn<int>(
                name: "ID_TAGS",
                table: "TB_TAGS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_NEGOCIACAO",
                table: "TB_COBRANCA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID_TAGS",
                table: "TB_TAGS",
                column: "ID_TAGS");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NEGOCIACAO_ID_CATEGORIA",
                table: "TB_NEGOCIACAO",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID_CATEGORIA",
                table: "TB_COBRANCA",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID_NEGOCIACAO",
                table: "TB_COBRANCA",
                column: "ID_NEGOCIACAO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARTAO_CREDITO_ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO",
                column: "ID_CARTAO_CREDITO");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO",
                column: "ID_CARTAO_CREDITO",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA",
                table: "TB_CARTAO_CREDITO",
                column: "ID_CONTA_BANCARIA",
                principalTable: "TB_CONTA_BANCARIA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_COBRANCA_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_COBRANCA",
                column: "ID_CATEGORIA",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_COBRANCA_TB_NEGOCIACAO_ID_NEGOCIACAO",
                table: "TB_COBRANCA",
                column: "ID_NEGOCIACAO",
                principalTable: "TB_NEGOCIACAO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_COBRANCA_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_COBRANCA",
                column: "ID_PAGAMENTO",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID_CONTA_BANCARIA",
                table: "TB_CONTA_BANCARIA",
                column: "ID_CONTA_BANCARIA",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                column: "ID_CATEGORIA",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR",
                column: "ID_PAGAMENTO",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_NEGOCIACAO",
                column: "ID_CATEGORIA",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_NEGOCIACAO",
                column: "ID_PAGAMENTO",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID_RECEITAS",
                table: "TB_RECEITAS",
                column: "ID_RECEITAS",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_TAG_ID",
                table: "TB_TAGS",
                column: "TAG_ID",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID_TAGS",
                table: "TB_TAGS",
                column: "ID_TAGS",
                principalTable: "TB_CONTAS_RECEBER",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_COBRANCA_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_COBRANCA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_COBRANCA_TB_NEGOCIACAO_ID_NEGOCIACAO",
                table: "TB_COBRANCA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_COBRANCA_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_COBRANCA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID_CONTA_BANCARIA",
                table: "TB_CONTA_BANCARIA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_CATEGORIAS_ID_CATEGORIA",
                table: "TB_NEGOCIACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_NEGOCIACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID_RECEITAS",
                table: "TB_RECEITAS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_TAG_ID",
                table: "TB_TAGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID_TAGS",
                table: "TB_TAGS");

            migrationBuilder.DropIndex(
                name: "IX_TB_TAGS_ID_TAGS",
                table: "TB_TAGS");

            migrationBuilder.DropIndex(
                name: "IX_TB_NEGOCIACAO_ID_CATEGORIA",
                table: "TB_NEGOCIACAO");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropIndex(
                name: "IX_TB_COBRANCA_ID_CATEGORIA",
                table: "TB_COBRANCA");

            migrationBuilder.DropIndex(
                name: "IX_TB_COBRANCA_ID_NEGOCIACAO",
                table: "TB_COBRANCA");

            migrationBuilder.DropIndex(
                name: "IX_TB_CARTAO_CREDITO_ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.DropColumn(
                name: "ID_TAGS",
                table: "TB_TAGS");

            migrationBuilder.DropColumn(
                name: "ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "ID_NEGOCIACAO",
                table: "TB_COBRANCA");

            migrationBuilder.DropColumn(
                name: "ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO");

            migrationBuilder.RenameColumn(
                name: "TAG_ID",
                table: "TB_TAGS",
                newName: "ID1");

            migrationBuilder.RenameIndex(
                name: "IX_TB_TAGS_TAG_ID",
                table: "TB_TAGS",
                newName: "IX_TB_TAGS_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_RECEITAS",
                table: "TB_RECEITAS",
                newName: "ID1");

            migrationBuilder.RenameIndex(
                name: "IX_TB_RECEITAS_ID_RECEITAS",
                table: "TB_RECEITAS",
                newName: "IX_TB_RECEITAS_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_PAGAMENTO",
                table: "TB_NEGOCIACAO",
                newName: "ID1");

            migrationBuilder.RenameColumn(
                name: "ID_CATEGORIA",
                table: "TB_NEGOCIACAO",
                newName: "CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_NEGOCIACAO_ID_PAGAMENTO",
                table: "TB_NEGOCIACAO",
                newName: "IX_TB_NEGOCIACAO_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR",
                newName: "ID1");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR",
                newName: "IX_TB_CONTAS_PAGAR_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_CONTA_BANCARIA",
                table: "TB_CONTA_BANCARIA",
                newName: "ID1");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA",
                table: "TB_CONTA_BANCARIA",
                newName: "IX_TB_CONTA_BANCARIA_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_PAGAMENTO",
                table: "TB_COBRANCA",
                newName: "ID1");

            migrationBuilder.RenameColumn(
                name: "ID_CATEGORIA",
                table: "TB_COBRANCA",
                newName: "CATEGORIA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_COBRANCA_ID_PAGAMENTO",
                table: "TB_COBRANCA",
                newName: "IX_TB_COBRANCA_ID1");

            migrationBuilder.RenameColumn(
                name: "ID_CONTA_BANCARIA",
                table: "TB_CARTAO_CREDITO",
                newName: "ID1");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CARTAO_CREDITO_ID_CONTA_BANCARIA",
                table: "TB_CARTAO_CREDITO",
                newName: "IX_TB_CARTAO_CREDITO_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID1",
                table: "TB_CARTAO_CREDITO",
                column: "ID1",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID1",
                table: "TB_CARTAO_CREDITO",
                column: "ID1",
                principalTable: "TB_CONTA_BANCARIA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_COBRANCA_TB_NEGOCIACAO_ID1",
                table: "TB_COBRANCA",
                column: "ID1",
                principalTable: "TB_NEGOCIACAO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_COBRANCA_TB_PAGAMENTO_ID1",
                table: "TB_COBRANCA",
                column: "ID1",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID1",
                table: "TB_CONTA_BANCARIA",
                column: "ID1",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID1",
                table: "TB_CONTAS_PAGAR",
                column: "ID1",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID1",
                table: "TB_CONTAS_PAGAR",
                column: "ID1",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID1",
                table: "TB_NEGOCIACAO",
                column: "ID1",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID1",
                table: "TB_RECEITAS",
                column: "ID1",
                principalTable: "TB_CONFIGURACOES",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID1",
                table: "TB_TAGS",
                column: "ID1",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID1",
                table: "TB_TAGS",
                column: "ID1",
                principalTable: "TB_CONTAS_RECEBER",
                principalColumn: "ID");
        }
    }
}
