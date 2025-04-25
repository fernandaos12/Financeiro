using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Commands
{
    public sealed record RemoverContaPagarCommand(int id) : IRequest<Result<bool>>;

}
