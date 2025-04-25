using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Queries
{
    public sealed record ListarContaPagarQuery() : IRequest<Result<List<ContasPagarDTO>>>;

}
