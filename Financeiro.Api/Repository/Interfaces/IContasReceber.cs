using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasReceber
    {
        IQueryable<ContasReceber> ListarContas();

        Task<ContasReceber> FindId(int id);
        Boolean Salvar(ContasReceber cr);
        void Atualizar(ContasReceber cr);
        Boolean Remover(int id);        
    }
}