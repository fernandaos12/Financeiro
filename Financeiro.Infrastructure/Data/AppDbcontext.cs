using Financeiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;

namespace Financeiro.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ContasPagar> ContasPagar { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<Categorias> Categorias { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
}

