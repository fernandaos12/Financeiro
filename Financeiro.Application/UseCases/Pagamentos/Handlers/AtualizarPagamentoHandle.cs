using Financeiro.Api.Repository;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Pagamentos.Commands;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamento.Handles
{
    public sealed class AtualizarPagamentoHandle(PagamentosRepository _repository)
                        : IRequestHandler<AtualizarPagamentoCommand, Result<PagamentoDTO>>
    {

        public async Task<Result<PagamentoDTO>> Handle(AtualizarPagamentoCommand request, CancellationToken cancellationToken)
        {
            var dados = new Domain.Entities.Pagamento
            {
                Id = request.Pgto.Id,
                Descricao = request.Pgto.Descricao,
                Valor = request.Pgto.Valor,
                DataPagamento = request.Pgto.DataPagamento,
                DataAlteracao = request.Pgto.DataAlteracao,
                DataVencimento = request.Pgto.DataVencimento,
                ValorPagamentoParcial = request.Pgto.ValorPagamentoParcial,
                ValorPagamentoTotal = request.Pgto.Valor,
                Status = request.Pgto.Status,
                StatusPagamento = request.Pgto.StatusPagamento,
                SaldoDevedor = request.Pgto.SaldoDevedor,
                MesCompetencia = request.Pgto.MesCompetencia,
                FormaPagamento = request.Pgto.FormaPagamento,
                Observacao = request.Pgto.Observacao,
            };
            await _repository.Atualizar(dados);


            return new Result<PagamentoDTO>(new PagamentoDTO { Id = dados.Id });
        }
    }
}
