using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ITags
    {
        Task<IEnumerable<Tags>> ListarContas();
        Task<Tags> FindId(int id);
        Task<Boolean> Salvar(Tags cp);
        void Atualizar(Tags cp);
        Task<Boolean> Remover(int id);

    }
}