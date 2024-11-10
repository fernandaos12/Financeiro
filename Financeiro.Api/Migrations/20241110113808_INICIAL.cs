using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class INICIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    ID_CONTA_BANCARIA = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTA_BANCARIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTA_BANCARIA_TB_CONFIGURACOES_ID_CONTA_BANCARIA",
                        column: x => x.ID_CONTA_BANCARIA,
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
                    ID_RECEITAS = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_RECEITAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_RECEITAS_TB_CONFIGURACOES_ID_RECEITAS",
                        column: x => x.ID_RECEITAS,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CARTAO_CREDITO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMERO_CARTAO = table.Column<int>(type: "int", nullable: false),
                    VALIDADE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NOME_NOCARTAO = table.Column<int>(type: "int", nullable: false),
                    ID_CONTA_BANCARIA = table.Column<int>(type: "int", nullable: false),
                    LIMITE_TOTAL = table.Column<double>(type: "double", nullable: false),
                    LIMITE_UTILIZADO = table.Column<double>(type: "double", nullable: false),
                    ID_CARTAO_CREDITO = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARTAO_CREDITO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID_CARTAO_CREDITO",
                        column: x => x.ID_CARTAO_CREDITO,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA",
                        column: x => x.ID_CONTA_BANCARIA,
                        principalTable: "TB_CONTA_BANCARIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CATEGORIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPOCATEGORIA = table.Column<int>(type: "int", nullable: false),
                    ID_CONTAPAGAR = table.Column<int>(type: "int", nullable: true),
                    COR_GRAFICO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIAS", x => x.ID);
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
                    COR_GRAFICO = table.Column<string>(type: "longtext", nullable: true)
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
                name: "TB_COBRANCA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID_PAGAMENTO = table.Column<int>(type: "int", nullable: true),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    NEGOCIA_DIVIDA = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ID_NEGOCIACAO = table.Column<int>(type: "int", nullable: true),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    COR_GRAFICO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COBRANCA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_COBRANCA_TB_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.ID_CATEGORIA,
                        principalTable: "TB_CATEGORIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_CONTAS_PAGAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    STATUS_CONTA = table.Column<int>(type: "int", nullable: false),
                    EMISSAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ID_PAGAMENTO = table.Column<int>(type: "int", nullable: true),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    PAGTO_PARCIAL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VALOR_PAGTO_PARCIAL = table.Column<double>(type: "double", nullable: false),
                    SALDO_DEVEDOR = table.Column<double>(type: "double", nullable: false),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: true),
                    REPETICAO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QDADE_REPETICAO = table.Column<int>(type: "int", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COR_GRAFICO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS_PAGAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.ID_CATEGORIA,
                        principalTable: "TB_CATEGORIAS",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_PAGAMENTO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MES_COMPETENCIA = table.Column<int>(type: "int", nullable: false),
                    FORMA_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    DATA_FECHAMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ID_CONTAPAGAR = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PAGAMENTO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_PAGAMENTO_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                        column: x => x.ID_CONTAPAGAR,
                        principalTable: "TB_CONTAS_PAGAR",
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
                    ID_CONTAPAGAR = table.Column<int>(type: "int", nullable: true),
                    ID_TAG = table.Column<int>(type: "int", nullable: true),
                    ID_TAGS = table.Column<int>(type: "int", nullable: true),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TAGS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                        column: x => x.ID_CONTAPAGAR,
                        principalTable: "TB_CONTAS_PAGAR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_TAGS_TB_CONTAS_PAGAR_ID_TAG",
                        column: x => x.ID_TAG,
                        principalTable: "TB_CONTAS_PAGAR",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_TAGS_TB_CONTAS_RECEBER_ID_TAGS",
                        column: x => x.ID_TAGS,
                        principalTable: "TB_CONTAS_RECEBER",
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
                    ID_PAGAMENTO = table.Column<int>(type: "int", nullable: true),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_TB_NEGOCIACAO_TB_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.ID_CATEGORIA,
                        principalTable: "TB_CATEGORIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_NEGOCIACAO_TB_PAGAMENTO_ID_PAGAMENTO",
                        column: x => x.ID_PAGAMENTO,
                        principalTable: "TB_PAGAMENTO",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARTAO_CREDITO_ID_CARTAO_CREDITO",
                table: "TB_CARTAO_CREDITO",
                column: "ID_CARTAO_CREDITO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARTAO_CREDITO_ID_CONTA_BANCARIA",
                table: "TB_CARTAO_CREDITO",
                column: "ID_CONTA_BANCARIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CATEGORIAS_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS",
                column: "ID_CONTAPAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID_CATEGORIA",
                table: "TB_COBRANCA",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID_NEGOCIACAO",
                table: "TB_COBRANCA",
                column: "ID_NEGOCIACAO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCA_ID_PAGAMENTO",
                table: "TB_COBRANCA",
                column: "ID_PAGAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTA_BANCARIA_ID_CONTA_BANCARIA",
                table: "TB_CONTA_BANCARIA",
                column: "ID_CONTA_BANCARIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_CATEGORIA",
                table: "TB_CONTAS_PAGAR",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_PAGAR_ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR",
                column: "ID_PAGAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_RECEBER_CategoriaId",
                table: "TB_CONTAS_RECEBER",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NEGOCIACAO_ID_CATEGORIA",
                table: "TB_NEGOCIACAO",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NEGOCIACAO_ID_PAGAMENTO",
                table: "TB_NEGOCIACAO",
                column: "ID_PAGAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PAGAMENTO_ID_CONTAPAGAR",
                table: "TB_PAGAMENTO",
                column: "ID_CONTAPAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECEITAS_ID_RECEITAS",
                table: "TB_RECEITAS",
                column: "ID_RECEITAS");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID_CONTAPAGAR",
                table: "TB_TAGS",
                column: "ID_CONTAPAGAR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID_TAG",
                table: "TB_TAGS",
                column: "ID_TAG");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TAGS_ID_TAGS",
                table: "TB_TAGS",
                column: "ID_TAGS");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CATEGORIAS_TB_CONTAS_PAGAR_ID_CONTAPAGAR",
                table: "TB_CATEGORIAS",
                column: "ID_CONTAPAGAR",
                principalTable: "TB_CONTAS_PAGAR",
                principalColumn: "ID");

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
                name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID_PAGAMENTO",
                table: "TB_CONTAS_PAGAR",
                column: "ID_PAGAMENTO",
                principalTable: "TB_PAGAMENTO",
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

            migrationBuilder.DropTable(
                name: "TB_CARTAO_CREDITO");

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

            migrationBuilder.DropTable(
                name: "TB_CONTAS_PAGAR");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "TB_PAGAMENTO");
        }
    }
}
