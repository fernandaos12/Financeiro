using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasReceberRepository
    {
        Task<IEnumerable<ContasReceber>> ListarContas();
        Task<ContasReceber> FindId(int id);
        Task<Boolean> Salvar(ContasReceber cr);
        Task<Boolean> Atualizar(ContasReceber cr);
        Task<Boolean> Remover(int id);
    }
}