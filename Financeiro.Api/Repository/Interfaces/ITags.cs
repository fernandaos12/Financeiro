using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ITags
    {
        Task<ServiceResponse<IEnumerable<Tags>>> Listar();
        Task<ServiceResponse<Tags>> FindId(int id);
        Task<ServiceResponse<Boolean>> Salvar(Tags cp);
        Task<ServiceResponse<Boolean>> Atualizar(Tags cp);
        Task<ServiceResponse<Boolean>> Remover(int id);
    }
}