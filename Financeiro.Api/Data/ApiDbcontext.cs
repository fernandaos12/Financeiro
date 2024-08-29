using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Api.Data
{
    public class ApiDbcontext : Dbcontext
    {
        public ApiDbcontext<ContasPagar> contaspagar {get;set;}
        
        protected override void OnConfiguring(
            DbcontextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("app.db;Cache=Shared");
               // base.OnConfiguring(optionsBuilder);
            }       

            public DbSet<ContasPagar> ContasPagar {get;set;}
            public DbSet<ContasReceber> ContasReceber {get;set;}
            public DbSet<Pagamento> Pagamento {get;set;}
            public DbSet<Categorias> Categorias {get;set;}
            
    }

}