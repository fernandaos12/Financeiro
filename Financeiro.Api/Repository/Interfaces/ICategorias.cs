using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ICategorias
    {
        Task<ServiceResponse<IEnumerable<Categorias>>> Listar();
        Task<ServiceResponse<Categorias>> FindId(int id);
        Task<ServiceResponse<Boolean>> Remover(int id);
        Task<ServiceResponse<Boolean>> Salvar(Categorias categoria);
        Task<ServiceResponse<Boolean>> Atualizar(Categorias categoria);
    }
}