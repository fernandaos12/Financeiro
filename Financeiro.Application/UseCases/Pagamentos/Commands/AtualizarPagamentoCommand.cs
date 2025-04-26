using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamentos.Commands
{
    public sealed class AtualizarPagamentoCommand(PagamentoDTO pgto) : IRequest<Result<PagamentoDTO>>
    {
        public PagamentoDTO Pgto { get; set; } = pgto;
    }
}
