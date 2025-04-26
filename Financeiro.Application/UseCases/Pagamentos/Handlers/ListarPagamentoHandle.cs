using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Pagamentos.Queries;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamento.Handles
{
    public sealed class ListarPagamentoHandle(IPagamentosRepository _repository)
             : IRequestHandler<ListarPagamentosQuery, Result<List<PagamentoDTO>>>
    {
        public async Task<Result<List<PagamentoDTO>>> Handle(ListarPagamentosQuery request, CancellationToken cancellationToken)
        {
            await _repository.Listar();
            return new Result<List<PagamentoDTO>>(new List<PagamentoDTO>());
        }
    }
}
