using Financeiro.Teste.Models;

namespace Financeiro.Teste.Interfaces
{
    public interface IContasPagarRepositoryTeste
    {
        Task<ContasPagarTesteModel> ObterContaPagarPorId(int id);
        Task<Boolean> SalvarContaPagar(ContasPagarTesteModel contaspagar);
        Task<Boolean> AtualizarContaPagar(ContasPagarTesteModel contaspagar);
        Task<Boolean> RemoverContaPagar(int id);
        Task<Boolean> AdicionarContaPagar(ContasPagarTesteModel contaspagar);

    }
}
