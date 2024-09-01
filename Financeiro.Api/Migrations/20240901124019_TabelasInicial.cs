using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class TabelasInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_Pagamento_PagamentoId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_CategoriaId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_CategoriaId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_PagamentoId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "PagamentoId",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "TAGS",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.RenameTable(
                name: "Pagamento",
                newName: "TB_PAGAMENTO");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "TB_CONTAS_PAGAR",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_CONTAS_PAGAR",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TB_CONTAS_PAGAR",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "tipoCategoria",
                table: "TB_CATEGORIAS",
                newName: "TIPOCATEGORIA");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "TB_CATEGORIAS",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_CATEGORIAS",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_CATEGORIAS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TB_CATEGORIAS",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "TB_PAGAMENTO",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_PAGAMENTO",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_PAGAMENTO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TB_PAGAMENTO",
                newName: "DATA_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "Conta",
                table: "TB_PAGAMENTO",
                newName: "MES_COMPETENCIA");

            migrationBuilder.AlterColumn<string>(
                name: "OBSERVACOES",
                table: "TB_CONTAS_PAGAR",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TB_CONTAS_PAGAR",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ID1",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TB_CATEGORIAS",
                keyColumn: "DESCRICAO",
                keyValue: null,
                column: "DESCRICAO",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TB_CATEGORIAS",
                type: "varchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "TB_PAGAMENTO",
                keyColumn: "DESCRICAO",
                keyValue: null,
                column: "DESCRICAO",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TB_PAGAMENTO",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DATA_FECHAMENTO",
                table: "TB_PAGAMENTO",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FORMA_PAGAMENTO",
                table: "TB_PAGAMENTO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "TB_CONFIGURACOES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<int>(type: "int", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONFIGURACOES", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CONTAS_RECEBER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    REPETICAO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CONFIRMADO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CONCILIADO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QDADE_REPETICOES = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTA = table.Column<int>(type: "int", nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    OBSERVACOES = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS_RECEBER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTAS_RECEBER_TB_CATEGORIAS_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TB_CATEGORIAS",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_NEGOCIACAO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PARCELADO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QDADE_PARCELAS = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NEGOCIACAO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_PAGAMENTO",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CONTA_BANCARIA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTA = table.Column<int>(type: "int", nullable: false),
                    AGENCIA = table.Column<int>(type: "int", nullable: false),
                    DIGITO = table.Column<int>(type: "int", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SALDO = table.Column<double>(type: "double", nullable: false),
                    SALDO_UTILIZADO = table.Column<double>(type: "double", nullable: false),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTA_BANCARIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_RECEITAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPO_RECEITA = table.Column<int>(type: "int", nullable: false),
                    TIPO_CONTA = table.Column<int>(type: "int", nullable: false),
                    MES_COMPETENCIA = table.Column<int>(type: "int", nullable: false),
                    VALIDADE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_RECEITAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_TAGS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TAGS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONTAS_PAGAR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONTAS_RECEBER",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_COBRANCA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    NEGOCIA_DIVIDA = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COBRANCA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_COBRANCA_TB_NEGOCIACAO_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_NEGOCIACAO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_COBRANCA_TB_PAGAMENTO_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_PAGAMENTO",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CARTAO_CREDITO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMERO_CARTAO = table.Column<int>(type: "int", nullable: false),
                    VALIDADE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NOME_NOCARTAO = table.Column<int>(type: "int", nullable: false),
                    ID1 = table.Column<int>(type: "int", nullable: false),
                    LIMITE_TOTAL = table.Column<double>(type: "double", nullable: false),
                    LIMITE_UTILIZADO = table.Column<double>(type: "double", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARTAO_CREDITO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CARTAO_CREDITO_TB_CONFIGURACOES_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONTA_BANCARIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_ID1",
                table: "TB_CONTAS_PAGAR",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_CARTAO_CREDITO_ID1",
                table: "CARTAO_CREDITO",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID1",
                table: "TB_COBRANCA",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTA_BANCARIA_ID1",
                table: "TB_CONTA_BANCARIA",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_RECEBER_CategoriaId",
                table: "TB_CONTAS_RECEBER",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NEGOCIACAO_ID1",
                table: "TB_NEGOCIACAO",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECEITAS_ID1",
                table: "TB_RECEITAS",
                column: "ID1");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID1",
                table: "TB_TAGS",
                column: "ID1");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropTable(
                name: "CARTAO_CREDITO");

            migrationBuilder.DropTable(
                name: "TB_COBRANCA");

            migrationBuilder.DropTable(
                name: "TB_RECEITAS");

            migrationBuilder.DropTable(
                name: "TB_TAGS");

            migrationBuilder.DropTable(
                name: "TB_CONTA_BANCARIA");

            migrationBuilder.DropTable(
                name: "TB_NEGOCIACAO");

            migrationBuilder.DropTable(
                name: "TB_CONTAS_RECEBER");

            migrationBuilder.DropTable(
                name: "TB_CONFIGURACOES");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_PAGAR_ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropColumn(
                name: "ID1",
                table: "TB_CONTAS_PAGAR");

            migrationBuilder.DropColumn(
                name: "DATA_FECHAMENTO",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropColumn(
                name: "FORMA_PAGAMENTO",
                table: "TB_PAGAMENTO");

            migrationBuilder.RenameTable(
                name: "TB_PAGAMENTO",
                newName: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "TB_CONTAS_PAGAR",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TB_CONTAS_PAGAR",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "TB_CONTAS_PAGAR",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "TIPOCATEGORIA",
                table: "TB_CATEGORIAS",
                newName: "tipoCategoria");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "TB_CATEGORIAS",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "TB_CATEGORIAS",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TB_CATEGORIAS",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "TB_CATEGORIAS",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Pagamento",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "Pagamento",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Pagamento",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DATA_ALTERACAO",
                table: "Pagamento",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "MES_COMPETENCIA",
                table: "Pagamento",
                newName: "Conta");

            migrationBuilder.UpdateData(
                table: "TB_CONTAS_PAGAR",
                keyColumn: "OBSERVACOES",
                keyValue: null,
                column: "OBSERVACOES",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "OBSERVACOES",
                table: "TB_CONTAS_PAGAR",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "TB_CONTAS_PAGAR",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoId",
                table: "TB_CONTAS_PAGAR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TAGS",
                table: "TB_CONTAS_PAGAR",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TB_CATEGORIAS",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(600)",
                oldMaxLength: 600)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Pagamento",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_CategoriaId",
                table: "TB_CONTAS_PAGAR",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_PagamentoId",
                table: "TB_CONTAS_PAGAR",
                column: "PagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_Pagamento_PagamentoId",
                table: "TB_CONTAS_PAGAR",
                column: "PagamentoId",
                principalTable: "Pagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_CategoriaId",
                table: "TB_CONTAS_PAGAR",
                column: "CategoriaId",
                principalTable: "TB_CATEGORIAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
