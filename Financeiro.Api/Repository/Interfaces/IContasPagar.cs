using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasPagar
    {
        Task<IEnumerable<ContasPagar>> ListarContas();
        Task<ContasPagar> FindId(int id);
        Task<Boolean> Salvar(ContasPagar cp);
        void Atualizar(ContasPagar cp);
        Task<Boolean> Remover(int id);
    }
}