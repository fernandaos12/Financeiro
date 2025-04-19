using Financeiro.Domain.Abstractions;
using Financeiro.Domain.Enums;

namespace Financeiro.Domain.Entities
{
    public class ContasReceber : Entity
    {
        public string? Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public bool Repeticao { get; set; }
        public bool Confirmado { get; set; }
        public FormaPagamentoEnum? Conta { get; set; } //se a conta é de cartao de credito
        public Categorias? Categorias { get; set; }
        public string? Observacoes { get; set; }
        public string? CorGrafico { get; set; }
        public String? CaminhoAnexos { get; set; } = String.Empty;
        public Byte[]? Anexos { get; set; }
        public List<string> Tags { get; set; } = new List<string>();

    }
}