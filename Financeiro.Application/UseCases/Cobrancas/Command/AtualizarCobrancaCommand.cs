using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Command
{
    public sealed class AtualizarCobrancaCommand(CobrancaDTO cobranca) : IRequest<Result<CobrancaDTO>>
    {
        public CobrancaDTO Cobranca { get; set; } = cobranca;
    }
}
