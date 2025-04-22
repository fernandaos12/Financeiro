using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Queries;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using Financeiro.Domain.Repository;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Handles
{
    public class ListarContasPagarQueryHandle(IContasPagarRepository _repo)
        : IRequestHandler<ListarContaPagarQuery, Result<List<ContasPagarDTO>>>
    {
        public async Task<Result<List<ContasPagarDTO>>> Handle(ListarContaPagarQuery request, CancellationToken cancellationToken)
        {
            var contas = await _repo.ListarContas() ?? throw new Exception("Contas nao encontradas");
            List<ContasPagarDTO> lista = contas.Select(c => new ContasPagarDTO
            {
                Id = c.Id,
                Descricao = c.Descricao,
                Data_Vencimento = c.Data_Vencimento,
                Valor = c.Valor,
                Observacao = c.Observacao ?? string.Empty,
                Status = c.Status,
                DataAlteracao = c.DataAlteracao,
                Status_Conta = c.Status_Conta,
                ValorPago = c.ValorPago,
                Categoria = c.Categoria,
                Repeticao = c.Repeticao,
                Periodicidade = c.Periodicidade,
                ValorParcela = c.ValorParcela,
                NumeroParcelas = c.NumeroParcelas,
                CaminhoAnexos = c.CaminhoAnexos,
                Anexos = c.Anexos,
                PagamentoId = c.PagamentoId,
                SaldoDevedorAtualizado = c.SaldoDevedorAtualizado
            }).ToList();

            return new Result<List<ContasPagarDTO>>(lista);


        }
    }
}
