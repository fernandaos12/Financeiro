using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Repository
{
    public interface IContasPagarRepository
    {
        Task<IEnumerable<ContasPagar>> ListarContas();
        Task<ContasPagar> FindId(int id);
        Task<Boolean> Salvar(ContasPagar contaspagar);
        Task<Boolean> Atualizar(ContasPagar contaspagar);
        Task<Boolean> Remover(int id);
    }
}