using Financeiro.Api.Repository;
using Financeiro.Application.UseCases.Pagamentos.Commands;
using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamento.Handles
{
    public sealed class GravarPagamentoHandle(PagamentosRepository repository) : IRequestHandler<GravarPagamentoCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(GravarPagamentoCommand request, CancellationToken cancellationToken)
        {
            var pgto = new Domain.Entities.Pagamento
            {
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

            await repository.Salvar(pgto);
            var resultado = new Result<string>("Sucesso, conta a pagar criado.");
            return resultado;
        }
    }
}
