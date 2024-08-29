using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Api.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public Datetime DataAlteracao { get; set; }
        public int Status { get; set; }
    }
}