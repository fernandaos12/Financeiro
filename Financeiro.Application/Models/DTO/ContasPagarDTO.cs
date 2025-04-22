using Financeiro.Domain.Enums;

namespace Financeiro.Application.Models.DTO;
public class ContasPagarDTO : BaseModel
{
    public string? Descricao { get; set; }
    public StatusConta Status_Conta { get; set; } = StatusConta.Pendente;
    public DateTime Data_Vencimento { get; set; } = DateTime.Now;
    public double Valor { get; set; }
    public TipoCategoria Categoria { get; set; }
    public TipoRepeticao Repeticao { get; set; } = TipoRepeticao.UNICO;
    public int? Periodicidade { get; set; }
    public int? ValorParcela { get; set; }
    public int? NumeroParcelas { get; set; }
    public string? CaminhoAnexos { get; set; } = string.Empty;
    public byte[]? Anexos { get; set; }
    public int PagamentoId { get; set; }
    public PagamentoDTO? Pagamento { get; set; }
    public double ValorPago { get; set; }
    public double SaldoDevedorAtualizado { get; set; }
    public string Observacao { get; set; } = string.Empty;
    public List<string>? Tags { get; internal set; }
}

