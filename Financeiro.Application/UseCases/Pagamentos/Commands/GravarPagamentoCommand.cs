using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamentos.Commands
{
    public sealed class GravarPagamentoCommand(PagamentoDTO pagamento) : IRequest<Result<string>>
    {
        public PagamentoDTO Pgto { get; set; } = pagamento;
    }
}
