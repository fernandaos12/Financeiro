using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Infrastructure.Data.Mapping;

public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.ToTable("TB_PAGAMENTOS");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Descricao)
            .IsRequired()
            .HasColumnName("DESCRICAO")
            .HasColumnType("NVARCHAR(500)");

        builder.Property(x => x.DataPagamento)
            .IsRequired()
            .HasColumnName("DATA_PAGAMENTO")
            .HasColumnType("DATETIME");

        builder.Property(x => x.DataAlteracao)
            .HasColumnName("DATA_ALTERACAO")
            .HasColumnType("DATETIME");

        builder.Property(x => x.MesCompetencia)
            .IsRequired()
            .HasColumnName("MES_COMPETENCIA")
            .HasColumnType("INT");

        builder.Property(x => x.Valor)
            .IsRequired()
            .HasColumnName("VALOR")
            .HasColumnType("DECIMAL(18,2)");

        builder.Property(x => x.PagamentoParcial)
            .HasColumnName("PARCIAL")
            .HasColumnType("BOOLEAN");

        builder.Property(x => x.ValorPagamentoTotal)
            .HasColumnName("PAGAMENTO_TOTAL")
            .HasColumnType("DECIMAL(18,2)");

        builder.Property(x => x.FormaPagamento)
            .IsRequired()
            .HasColumnName("FORMA_PAGAMENTO")
            .HasColumnType("INT");

        builder.HasMany(x => x.ContasPagar)
            .WithOne(x => x.Pagamento)
            .HasForeignKey(x => x.PagamentoId);

        builder.Property(x => x.Status)
            .HasColumnName("STATUS")
            .HasConversion<Status_Default>();

        builder.Property(x => x.StatusPagamento)
            .HasColumnName("STATUS_PAGAMENTO")
            .HasConversion<StatusConta>();
    }
}


