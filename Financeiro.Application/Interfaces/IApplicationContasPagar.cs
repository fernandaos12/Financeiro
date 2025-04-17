using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Application.Interfaces
{
    public interface IApplicationContasPagar
    {
        Task<ServiceResponse<IEnumerable<ContasPagarDTO>>> ListarContas();
        Task<ServiceResponse<ContasPagarDTO>> FindId(int id);
        Task<ServiceResponse<Boolean>> Salvar(ContasPagarDTO contaspagar);
        Task<ServiceResponse<Boolean>> Atualizar(ContasPagarDTO contaspagar);
        Task<ServiceResponse<Boolean>> Remover(int id);
    }
}
