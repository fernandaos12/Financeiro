using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasReceber
    {
        Task <ServiceResponse<IEnumerable<ContasReceber>>> ListarContas();
        Task<ServiceResponse<ContasReceber>> FindId(int id);
        Task<ServiceResponse<Boolean>> Salvar(ContasReceber cr);
        Task<ServiceResponse<Boolean>> Atualizar(ContasReceber cr);
        Task<ServiceResponse<Boolean>> Remover(int id);        
    }
}