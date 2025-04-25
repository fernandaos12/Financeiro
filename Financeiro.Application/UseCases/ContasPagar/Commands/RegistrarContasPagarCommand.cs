using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Commands
{
    public sealed record RegistrarContasPagarCommand(ContasPagarDTO contas) : IRequest<Result<string>>;

}
