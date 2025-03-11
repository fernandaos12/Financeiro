using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ICategorias
    {
        Task<ServiceResponse<IEnumerable<CategoriaReceitas>>> Listar();
        Task<ServiceResponse<CategoriaReceitas>> FindId(int id);
        Task<ServiceResponse<Boolean>> Remover(int id);
        Task<ServiceResponse<Boolean>> Salvar(CategoriaReceitas categoria);
        Task<ServiceResponse<Boolean>> Atualizar(CategoriaReceitas categoria);
    }
}