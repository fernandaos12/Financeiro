using Financeiro.Api.Models.Base;

namespace Financeiro.Api.Models
{
    public class ContasPagar : BaseModel
    {        
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Repeticao { get; set; }
        public bool Confirmado { get; set; }
        public bool Conciliado { get; set; }
        public int QdadeRepeticoes { get; set; }
        public string Descricao { get; set; }
        public string Conta { get; set; }
        public Categorias Categoria { get; set; }
        public string Observacoes { get; set; }
        public List<string> Tags { get; set; }
                
    }
}