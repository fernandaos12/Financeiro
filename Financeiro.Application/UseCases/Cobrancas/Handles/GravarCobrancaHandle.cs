using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Cobrancas.Command;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Handles
{
    public sealed class GravarPagamentoHandle(ICobrancasRepository repository) : IRequestHandler<GravarCobrancaCommand, Result<CobrancaDTO>>
    {
        public async Task<Result<CobrancaDTO>> Handle(GravarCobrancaCommand request, CancellationToken cancellationToken)
        {
            var cob = new Domain.Entities.Cobrancas
            {
                Id = request.Cobranca.Id,
                Descricao = request.Cobranca.Descricao,
                Valor = request.Cobranca.Valor,
                Vencimento = request.Cobranca.Vencimento,
                PagamentoId = request.Cobranca.PagamentoId ?? null,
                Pago = request.Cobranca.Pago,
                CategoriaDivida = request.Cobranca.CategoriaDivida,
                DividaNegociada = request.Cobranca.DividaNegociada,
                NegociacaoId = request.Cobranca.NegociacaoId,
                CorGrafico = request.Cobranca.CorGrafico
            };

            await repository.GravarCobranca(cob);
            return new Result<CobrancaDTO>(new CobrancaDTO { Id = cob.Id });
        }
    }
}
