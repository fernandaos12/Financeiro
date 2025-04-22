using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Queries
{
    public sealed record ListarContaPagarQuery() : IRequest<Result<List<ContasPagarDTO>>>;

}
