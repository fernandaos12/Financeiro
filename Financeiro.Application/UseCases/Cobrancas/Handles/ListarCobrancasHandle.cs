using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Cobrancas.Queries;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Handles
{
    public sealed record ListarPagamentoHandle(ICobrancasRepository _repository) : IRequestHandler<ListarCobrancasQuery, Result<List<CobrancaDTO>>>
    {
        public async Task<Result<List<CobrancaDTO>>> Handle(ListarCobrancasQuery request, CancellationToken cancellationToken)
        {
            await _repository.Listar();
            return new Result<List<CobrancaDTO>>(new List<CobrancaDTO>());
        }
    }
}
