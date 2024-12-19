﻿// <auto-generated />
using System;
using Financeiro.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Financeiro.Api.Migrations
{
    [DbContext(typeof(ApiDbcontext))]
    [Migration("20241219140530_contasPagarAlteracoesFK")]
    partial class contasPagarAlteracoesFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Financeiro.Api.Models.CartaoCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_FECHAMENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.Property<int?>("ID_CARTAO_CREDITO")
                        .HasColumnType("int");

                    b.Property<int>("ID_CONTA_BANCARIA")
                        .HasColumnType("int");

                    b.Property<double>("LimiteTotal")
                        .HasColumnType("double")
                        .HasColumnName("LIMITE_TOTAL");

                    b.Property<double>("LimiteUtilizado")
                        .HasColumnType("double")
                        .HasColumnName("LIMITE_UTILIZADO");

                    b.Property<int>("NomeNoCartao")
                        .HasColumnType("int")
                        .HasColumnName("NOME_NOCARTAO");

                    b.Property<int>("NumeroCartao")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO_CARTAO");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VALIDADE");

                    b.HasKey("Id");

                    b.HasIndex("ID_CARTAO_CREDITO");

                    b.HasIndex("ID_CONTA_BANCARIA");

                    b.ToTable("TB_CARTAO_CREDITO");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("CorGrafico")
                        .HasColumnType("longtext")
                        .HasColumnName("COR_GRAFICO");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<int>("tipoCategoria")
                        .HasColumnType("int")
                        .HasColumnName("TIPOCATEGORIA");

                    b.HasKey("Id");

                    b.ToTable("TB_CATEGORIAS");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Cobranca_Negociacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("ID_CATEGORIA")
                        .HasColumnType("int");

                    b.Property<int?>("ID_PAGAMENTO")
                        .HasColumnType("int");

                    b.Property<bool?>("Parcelado")
                        .IsRequired()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("PARCELADO");

                    b.Property<int?>("QdadeParcelas")
                        .HasColumnType("int")
                        .HasColumnName("QDADE_PARCELAS");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<double?>("Valor")
                        .IsRequired()
                        .HasColumnType("double")
                        .HasColumnName("VALOR");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VENCIMENTO");

                    b.HasKey("Id");

                    b.HasIndex("ID_CATEGORIA");

                    b.HasIndex("ID_PAGAMENTO");

                    b.ToTable("TB_NEGOCIACAO");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Cobrancas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("CorGrafico")
                        .HasColumnType("longtext")
                        .HasColumnName("COR_GRAFICO");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("ID_CATEGORIA")
                        .HasColumnType("int");

                    b.Property<int?>("ID_NEGOCIACAO")
                        .HasColumnType("int");

                    b.Property<int?>("ID_PAGAMENTO")
                        .HasColumnType("int");

                    b.Property<bool>("NegociaDivida")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("NEGOCIA_DIVIDA");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<double?>("Valor")
                        .IsRequired()
                        .HasColumnType("double")
                        .HasColumnName("VALOR");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VENCIMENTO");

                    b.HasKey("Id");

                    b.HasIndex("ID_CATEGORIA");

                    b.HasIndex("ID_NEGOCIACAO");

                    b.HasIndex("ID_PAGAMENTO");

                    b.ToTable("TB_COBRANCA");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Configuracoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("NOME");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<int>("telefone")
                        .HasColumnType("int")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("TB_CONFIGURACOES");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContaBancaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("Agencia")
                        .HasColumnType("int")
                        .HasColumnName("AGENCIA");

                    b.Property<int>("Conta")
                        .HasColumnType("int")
                        .HasColumnName("CONTA");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("Digito")
                        .HasColumnType("int")
                        .HasColumnName("DIGITO");

                    b.Property<int?>("ID_CONTA_BANCARIA")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("OBSERVACOES");

                    b.Property<double>("SaldoTotal")
                        .HasColumnType("double")
                        .HasColumnName("SALDO");

                    b.Property<double>("SaldoUtilizado")
                        .HasColumnType("double")
                        .HasColumnName("SALDO_UTILIZADO");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTA_BANCARIA");

                    b.ToTable("TB_CONTA_BANCARIA");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContasPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Anexos")
                        .HasColumnType("longtext")
                        .HasColumnName("ANEXOS");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("CATEGORIAID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VENCIMENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int?>("ID_CATEGORIA")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroParcelas")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO_PARCELAS");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext")
                        .HasColumnName("OBSERVACOES");

                    b.Property<int?>("Periodicidade")
                        .HasColumnType("int")
                        .HasColumnName("PERIODICIDADE");

                    b.Property<int?>("Repeticao")
                        .HasColumnType("int")
                        .HasColumnName("REPETICAO");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<int>("Status_Conta")
                        .HasColumnType("int")
                        .HasColumnName("STATUS_CONTA");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("VALOR");

                    b.Property<int?>("ValorParcela")
                        .HasColumnType("int")
                        .HasColumnName("VALOR_PARCELA");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TB_CONTAS_PAGAR");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContasReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Conciliado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("CONCILIADO");

                    b.Property<bool>("Confirmado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("CONFIRMADO");

                    b.Property<int?>("Conta")
                        .HasColumnType("int")
                        .HasColumnName("CONTA");

                    b.Property<string>("CorGrafico")
                        .HasColumnType("longtext")
                        .HasColumnName("COR_GRAFICO");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VENCIMENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext")
                        .HasColumnName("OBSERVACOES");

                    b.Property<int>("QdadeRepeticoes")
                        .HasColumnType("int")
                        .HasColumnName("QDADE_REPETICOES");

                    b.Property<bool>("Repeticao")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("REPETICAO");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("VALOR");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TB_CONTAS_RECEBER");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("int")
                        .HasColumnName("FORMA_PAGAMENTO");

                    b.Property<int?>("ID_CONTAPAGAR")
                        .HasColumnType("int");

                    b.Property<int>("MesCompetencia")
                        .HasColumnType("int")
                        .HasColumnName("MES_COMPETENCIA");

                    b.Property<bool>("PagamentoParcial")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("PAGTO_PARCIAL");

                    b.Property<double>("SaldoDevedor")
                        .HasColumnType("double")
                        .HasColumnName("SALDO_DEVEDOR");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<double>("ValorPagamentoParcial")
                        .HasColumnType("double")
                        .HasColumnName("VALOR_PAGTO_PARCIAL");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTAPAGAR");

                    b.ToTable("TB_PAGAMENTO");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Receitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<DateTime>("DataRecebimento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("VALIDADE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.Property<int?>("ID_RECEITAS")
                        .HasColumnType("int");

                    b.Property<int>("MesCompetencia")
                        .HasColumnType("int")
                        .HasColumnName("MES_COMPETENCIA");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.Property<int>("TipoConta")
                        .HasColumnType("int")
                        .HasColumnName("TIPO_CONTA");

                    b.Property<int>("TipoReceita")
                        .HasColumnType("int")
                        .HasColumnName("TIPO_RECEITA");

                    b.HasKey("Id");

                    b.HasIndex("ID_RECEITAS");

                    b.ToTable("TB_RECEITAS");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATA_ALTERACAO");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.Property<int?>("ID_CONTAPAGAR")
                        .HasColumnType("int");

                    b.Property<int?>("ID_TAGS")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("ID_CONTAPAGAR");

                    b.HasIndex("ID_TAGS");

                    b.ToTable("TB_TAGS");
                });

            modelBuilder.Entity("Financeiro.Api.Models.CartaoCredito", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Configuracoes", null)
                        .WithMany("CartaoCredito")
                        .HasForeignKey("ID_CARTAO_CREDITO");

                    b.HasOne("Financeiro.Api.Models.ContaBancaria", "Banco")
                        .WithMany()
                        .HasForeignKey("ID_CONTA_BANCARIA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Cobranca_Negociacao", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Categorias", "CategoriaDivida")
                        .WithMany()
                        .HasForeignKey("ID_CATEGORIA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Financeiro.Api.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("ID_PAGAMENTO");

                    b.Navigation("CategoriaDivida");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Cobrancas", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Categorias", "CategoriaDivida")
                        .WithMany()
                        .HasForeignKey("ID_CATEGORIA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Financeiro.Api.Models.Cobranca_Negociacao", "NegociacaoDivida")
                        .WithMany()
                        .HasForeignKey("ID_NEGOCIACAO");

                    b.HasOne("Financeiro.Api.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("ID_PAGAMENTO");

                    b.Navigation("CategoriaDivida");

                    b.Navigation("NegociacaoDivida");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContaBancaria", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Configuracoes", null)
                        .WithMany("ContasBancarias")
                        .HasForeignKey("ID_CONTA_BANCARIA");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContasPagar", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Categorias", "Categoria")
                        .WithMany("ContasPagar")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContasReceber", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Categorias", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Pagamento", b =>
                {
                    b.HasOne("Financeiro.Api.Models.ContasPagar", "Id_ContaPagar")
                        .WithMany()
                        .HasForeignKey("ID_CONTAPAGAR");

                    b.Navigation("Id_ContaPagar");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Receitas", b =>
                {
                    b.HasOne("Financeiro.Api.Models.Configuracoes", null)
                        .WithMany("Receitas")
                        .HasForeignKey("ID_RECEITAS");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Tags", b =>
                {
                    b.HasOne("Financeiro.Api.Models.ContasPagar", "Id_ContaPagar")
                        .WithMany()
                        .HasForeignKey("ID_CONTAPAGAR");

                    b.HasOne("Financeiro.Api.Models.ContasReceber", null)
                        .WithMany("Tags")
                        .HasForeignKey("ID_TAGS");

                    b.Navigation("Id_ContaPagar");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Categorias", b =>
                {
                    b.Navigation("ContasPagar");
                });

            modelBuilder.Entity("Financeiro.Api.Models.Configuracoes", b =>
                {
                    b.Navigation("CartaoCredito");

                    b.Navigation("ContasBancarias");

                    b.Navigation("Receitas");
                });

            modelBuilder.Entity("Financeiro.Api.Models.ContasReceber", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
