using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Queries
{
    public sealed class ListarCobrancasQuery() : IRequest<Result<List<CobrancaDTO>>>;

}
