using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    public class Pagamento : BaseModel
    {
        public string? Descricao { get; set; }
        public TipoConta Conta { get; set; }

    }
}