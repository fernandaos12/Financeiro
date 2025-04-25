using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Infrastructure.Data.Mapping;

public class ContasPagarMap : IEntityTypeConfiguration<ContasPagar>
{
    public void Configure(EntityTypeBuilder<ContasPagar> builder)
    {
        builder.ToTable("CONTAS_PAGAR");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Descricao)
            .IsRequired()
            .HasMaxLength(500)
            .HasColumnName("DESCRICAO")
            .HasColumnType("NVARCHAR(500)");

        builder.Property(x => x.Observacoes)
            .IsRequired()
            .HasMaxLength(500)
            .HasColumnName("OBSERVACOES")
            .HasColumnType("NVARCHAR(500)");

        builder.Property(x => x.Valor)
            .HasColumnType("DECIMAL(18,2)")
            .HasColumnName("VALOR")
            .IsRequired();

        builder.Property(x => x.Periodicidade)
            .HasColumnType("INT")
            .HasColumnName("PERIODICIDADE")
            .IsRequired();

        builder.Property(c => c.Categoria)
            .HasColumnName("CATEGORIA")
            .HasConversion<TipoCategoria>();

        builder.Property(x => x.Data_Vencimento)
           .HasColumnType("DATETIME")
           .HasColumnName("DATA_VENCIMENTO")
           .IsRequired();

        builder.Property(x => x.NumeroParcelas)
           .HasColumnType("INT")
           .HasColumnName("PARCELAS");

        builder.HasOne(x => x.Pagamento)
            .WithMany(x => x.ContasPagar)
            .HasForeignKey(x => x.PagamentoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.Repeticao)
            .HasConversion<TipoRepeticao>()
            .HasColumnName("REPETICAO")
            .IsRequired();

        builder.Property(x => x.Status)
            .HasConversion<Status_Default>()
            .HasColumnName("STATUS");

        builder.Property(x => x.Status_Conta)
            .HasConversion<StatusConta>()
            .HasColumnName("STATUS_CONTA")
            .IsRequired();

        builder.Property(x => x.ValorParcela)
           .HasColumnType("INT")
           .HasColumnName("VALOR_PARCELA");

        builder.Property(x => x.CaminhoAnexos)
           .HasColumnType("NVARCHAR(1500)")
           .HasColumnName("CAMINHO_ANEXOS");

        builder.Property(x => x.Anexos)
           .HasColumnType("VARBINARY(MAX)")
           .HasColumnName("ANEXO");

    }
}