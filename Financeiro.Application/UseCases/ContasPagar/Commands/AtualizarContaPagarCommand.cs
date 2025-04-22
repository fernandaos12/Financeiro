using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Commands
{
    public sealed record AtualizarContaPagarCommand : IRequest<Result<ContasPagarDTO>>
    {
        public ContasPagarDTO Contas { get; set; }
        public AtualizarContaPagarCommand(ContasPagarDTO contas)
        {
            Contas = contas;
        }
    }
}
