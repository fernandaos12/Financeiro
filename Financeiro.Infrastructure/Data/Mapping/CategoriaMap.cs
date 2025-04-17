using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeiro.Infrastructure.Data.Mapping;
public class CategoriaMap : IEntityTypeConfiguration<Categorias>
{
    public void Configure(EntityTypeBuilder<Categorias> builder)
    {
        builder.ToTable("TB_CATEGORIAS");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Descricao)
            .IsRequired()
            .HasColumnType("NVARCHAR(500)")
            .HasColumnName("DESCRICAO");

        builder.Property(x => x.TipoCategoria)
            .IsRequired()
            .HasConversion<TipoCategoria>()
            .HasColumnName("TIPO_CATEGORIA");
    }
}
