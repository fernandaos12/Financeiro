using Financeiro.Api.Models.Base;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Api.Models
{
    public class ContasReceber : BaseModel
    {
        public string? Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public bool Repeticao { get; set; }
        public bool Confirmado { get; set; }
        public TipoConta? Conta { get; set; } //se a conta é de cartao de credito
        public Categorias? Categorias { get; set; }
        public string? Observacoes { get; set; }
        public string? CorGrafico { get; set; }
        public String? CaminhoAnexos { get; set; } = String.Empty;
        public Byte[]? Anexos { get; set; }

    }
}