using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models
{
    public class Configuracoes : BaseModel
    {
        public string? Descricao { get; set; }
    }
}