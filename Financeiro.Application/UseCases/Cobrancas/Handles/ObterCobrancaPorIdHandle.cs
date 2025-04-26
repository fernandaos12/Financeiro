using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Cobrancas.Queries;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Handles
{
    public sealed class ObterPagamentoPorIdHandle(ICobrancasRepository repository) : IRequestHandler<ObterCobrancaPorIdQuery, Result<CobrancaDTO>>
    {
        public async Task<Result<CobrancaDTO>> Handle(ObterCobrancaPorIdQuery request, CancellationToken cancellationToken)
        {
            await repository.BuscarCobrancaItem(request.Id);
            return new Result<CobrancaDTO>(new CobrancaDTO { Id = request.Id });
        }
    }
}
