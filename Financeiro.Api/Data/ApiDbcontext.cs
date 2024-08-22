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

    }

}