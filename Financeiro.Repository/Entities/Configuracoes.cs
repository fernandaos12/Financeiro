using Financeiro.Domain.Abstractions;

namespace Financeiro.Domain.Entities
{

    public class Configuracoes : Entity
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int telefone { get; set; }
        public List<Receitas>? Receitas { get; set; }
        public List<CartaoCredito>? CartaoCredito { get; set; }
        public List<ContaBancaria>? ContasBancarias { get; set; }
    }
}