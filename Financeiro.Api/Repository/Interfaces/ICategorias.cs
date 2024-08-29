using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface ICategorias
    {
        IQueryable<Categorias> Listar();
        Task<Categorias> FindId(int id);
        Boolean Salvar(Categorias categoria);
        void Atualizar(Categorias categoria);
        Boolean Remover(int id);
    }
}