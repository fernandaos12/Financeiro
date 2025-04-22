using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Commands
{
    public sealed record RemoverContaPagarCommand(int id) : IRequest<Result<ContasPagarDTO>>;

}
