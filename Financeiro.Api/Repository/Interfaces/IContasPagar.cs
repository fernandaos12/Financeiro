using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasPagar
    {
        Task<ServiceResponse<IEnumerable<ContasPagar>>> ListarContas();
        Task<ServiceResponse<ContasPagar>> FindId(int id);
        Task<ServiceResponse<Boolean>> Salvar(ContasPagar contaspagar);
        Task<ServiceResponse<Boolean>> Atualizar(ContasPagar contaspagar);
        Task<ServiceResponse<Boolean>> Remover(int id);
    }
}