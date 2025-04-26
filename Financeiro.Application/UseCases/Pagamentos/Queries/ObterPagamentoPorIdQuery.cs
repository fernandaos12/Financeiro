using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamentos.Queries
{
    public sealed class ObterPagamentoPorIdQuery(int id) : IRequest<Result<PagamentoDTO>>
    {
        public int Id { get; set; } = id;
    }
}
