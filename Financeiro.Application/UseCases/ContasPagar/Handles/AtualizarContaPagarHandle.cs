using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.Response;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Handles
{
    public sealed class AtualizarContaPagarHandle(IContasPagarRepository repo) : IRequestHandler<AtualizarContaPagarCommand, Result<ContasPagarDTO>>
    {
        public async Task<Result<ContasPagarDTO>> Handle(AtualizarContaPagarCommand request, CancellationToken cancellationToken)
        {
            // var item = repo.FindId(request.Contas.Id) ?? throw new Exception("Conta nao encontrada");

            var contaEncontrada = new Domain.Entities.ContasPagar
            {
                Id = request.Contas.Id,
                Descricao = request.Contas.Descricao,
                Data_Vencimento = request.Contas.Data_Vencimento,
                Valor = request.Contas.Valor,
                Observacao = request.Contas.Observacao,
                Status = request.Contas.Status,
                DataAlteracao = DateTime.Now,
                Status_Conta = request.Contas.Status_Conta,
                ValorPago = request.Contas.ValorPago,
                Categoria = request.Contas.Categoria,
                Repeticao = request.Contas.Repeticao,
                Periodicidade = request.Contas.Periodicidade,
                ValorParcela = request.Contas.ValorParcela,
                NumeroParcelas = request.Contas.NumeroParcelas,
                CaminhoAnexos = request.Contas.CaminhoAnexos,
                Anexos = request.Contas.Anexos,
                PagamentoId = null,
                SaldoDevedorAtualizado = request.Contas.SaldoDevedorAtualizado,
            };

            await repo.Atualizar(contaEncontrada);
            return new Result<ContasPagarDTO>(new ContasPagarDTO { Id = request.Contas.Id });
        }
    }
}
