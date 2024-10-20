using Financeiro.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Data
{
    public class ApiDbcontext : DbContext
    {
        public ApiDbcontext(DbContextOptions<ApiDbcontext> _options) : base(_options)
        {            
        }
        public DbSet<ContasPagar> contasPagar { get; set; }
        public DbSet<ContasReceber> ContasReceber { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
        public DbSet<Cobrancas> Cobrancas { get; set; }
        public DbSet<ContaBancaria> ContaBancaria { get; set; }
        public DbSet<CartaoCredito> CartaoCredito { get; set; }
        public DbSet<Cobranca_Negociacao> CobrancaNegociacao { get; set; }
        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Tags> Tags { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<ContasPagar>(a=> 
        //     {
        //         a.HasKey(p=>p.Id);
        //         a.Property(p=>p.Descricao).HasMaxLength(500).HasColumnType("varchar(500)");
        //         a.HasMany(p=>p.Tags).WithOne().HasForeignKey(p=>p.Id);
        //         });
        // }
    }
}