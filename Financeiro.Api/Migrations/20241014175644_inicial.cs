using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Api.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIAS", x => x.ID);
                })
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
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PAGAMENTO", x => x.ID);
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
                name: "TB_CONTAS_PAGAR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMISSAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VENCIMENTO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VALOR = table.Column<double>(type: "double", nullable: false),
                    PAGTO_PARCIAL = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VALOR_PAGTO_PARCIAL = table.Column<double>(type: "double", nullable: false),
                    SALDO_DEVEDOR = table.Column<double>(type: "double", nullable: false),
                    ID1 = table.Column<int>(type: "int", nullable: true),
                    REPETICAO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QDADE_REPETICAO = table.Column<int>(type: "int", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS_PAGAR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTAS_PAGAR_TB_CATEGORIAS_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CATEGORIAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TB_CONTAS_PAGAR_TB_PAGAMENTO_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_PAGAMENTO",
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
                    ID1 = table.Column<int>(type: "int", nullable: false),
                    LIMITE_TOTAL = table.Column<double>(type: "double", nullable: false),
                    LIMITE_UTILIZADO = table.Column<double>(type: "double", nullable: false),
                    DATA_ALTERACAO = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARTAO_CREDITO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_CARTAO_CREDITO_TB_CONFIGURACOES_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONFIGURACOES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_CARTAO_CREDITO_TB_CONTA_BANCARIA_ID1",
                        column: x => x.ID1,
                        principalTable: "TB_CONTA_BANCARIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_TB_CARTAO_CREDITO_ID1",
                table: "TB_CARTAO_CREDITO",
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
                name: "IX_TB_CONTAS_PAGAR_ID1",
                table: "TB_CONTAS_PAGAR",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "TB_CONTAS_PAGAR");

            migrationBuilder.DropTable(
                name: "TB_CONTAS_RECEBER");

            migrationBuilder.DropTable(
                name: "TB_CONFIGURACOES");

            migrationBuilder.DropTable(
                name: "TB_PAGAMENTO");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIAS");
        }
    }
}
