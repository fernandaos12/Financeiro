using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamentos.Queries
{
    public sealed class ListarPagamentosQuery() : IRequest<Result<List<PagamentoDTO>>>;

}
