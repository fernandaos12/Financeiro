using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ICategoriasRepository
    {
        Task<IEnumerable<Categorias>> Listar();
        Task<Categorias> FindId(int id);
        Task<Boolean> Remover(int id);
        Task<Boolean> Salvar(Categorias categoria);
        Task<Boolean> Atualizar(Categorias categoria);
    }
}