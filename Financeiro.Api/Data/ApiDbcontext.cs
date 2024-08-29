using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Data
{
    public class ApiDbcontext : DbContext
    {
        public ApiDbcontext(DbContextOptions<ApiDbcontext> _options) : base(_options)
        {            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }   

            public DbSet<ContasPagar> ContasPagar {get;set;}
            public DbSet<ContasReceber> ContasReceber {get;set;}
            public DbSet<Pagamento> Pagamento {get;set;}
            public DbSet<Categorias> Categorias {get;set;}            
    }
}