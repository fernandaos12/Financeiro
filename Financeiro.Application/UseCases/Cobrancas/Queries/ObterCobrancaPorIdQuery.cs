using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Queries
{
    public sealed class ObterCobrancaPorIdQuery(int id) : IRequest<Result<CobrancaDTO>>
    {
        public int Id { get; set; } = id;
    }


}
