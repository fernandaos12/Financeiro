using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasReceber
    {
        Task <IEnumerable<ContasReceber>> ListarContas();
        Task<ContasReceber> FindId(int id);
        Task<bool> Salvar(ContasReceber cr);
        Task<bool> Atualizar(ContasReceber cr);
        Task<bool> Remover(int id);        
    }
}