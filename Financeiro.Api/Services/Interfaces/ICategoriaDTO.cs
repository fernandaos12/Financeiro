using Financeiro.Api.Models.DTO;

namespace Financeiro.Api.Services.Interfaces
{
    public interface ICategoriaDTO
    {
        Task<List<CategoriaDTO>> Listar();
        Task<CategoriaDTO> BuscarPorId(int id);
        Task<CategoriaDTO> Cadastrar(CategoriaDTO categoria);
        Task<CategoriaDTO> Atualizar(CategoriaDTO categoria);
        Task<bool> Excluir(int id);
    }
}
