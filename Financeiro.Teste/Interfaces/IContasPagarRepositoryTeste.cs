using Financeiro.Api.Models;
using Financeiro.Teste.Models;

namespace Financeiro.Teste.Interfaces
{
    public interface IContasPagarRepositoryTeste
    {
        Task<ContasPagar> ObterContaPagarPorId(int id);
        Task<Boolean> SalvarContaPagar(ContasPagarTesteModel contaspagar);
        Task<Boolean> AtualizarContaPagar(ContasPagarTesteModel contaspagar);
        Task<Boolean> RemoverContaPagar(int id);

    }
}
