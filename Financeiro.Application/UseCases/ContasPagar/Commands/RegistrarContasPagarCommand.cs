using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Commands
{
    public sealed record RegistrarContasPagarCommand : IRequest<Result<string>>
    {
        public ContasPagarDTO ContasAPagar { get; private set; }

        public RegistrarContasPagarCommand(ContasPagarDTO contas)
        {
            ContasAPagar = contas;
        }
    }

}
