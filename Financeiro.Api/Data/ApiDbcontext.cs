using Financeiro.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Data
{
    public class ApiDbcontext(DbContextOptions<ApiDbcontext> options) : DbContext(options)
    {
        public DbSet<ContasPagar> ContasPagar { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        //public DbSet<ContasReceber> ContasReceber { get; set; }
        //public DbSet<Receitas> Receitas { get; set; }
        //public DbSet<Configuracoes> Configuracoes { get; set; }
        //public DbSet<Cobrancas> Cobrancas { get; set; }
        //public DbSet<ContaBancaria> ContaBancaria { get; set; }
        //public DbSet<CartaoCredito> CartaoCredito { get; set; }
        //public DbSet<Cobranca_Negociacao> CobrancaNegociacao { get; set; }
        //public DbSet<Tags> Tags { get; set; }

        //todos mapeamentos encontrados ele vai aplicar
        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
    }
}