using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ICategorias
    {
        Task<IEnumerable<Categorias>> Listar();
        Task<Categorias> FindId(int id);
        Task<bool> Remover(int id);
        Task<bool> Salvar(Categorias categoria);
        Task<bool> Atualizar(Categorias categoria);
    }
}