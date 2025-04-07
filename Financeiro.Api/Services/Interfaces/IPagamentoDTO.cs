using Financeiro.Api.Models.DTO;

namespace Financeiro.Api.Services.Interfaces
{
    public interface IPagamentoDTO
    {
        Task<List<PagamentoDTO>> Listar();
        Task<PagamentoDTO> BuscarPorId(int id);
        Task<PagamentoDTO> Cadastrar(PagamentoDTO pgto);
        Task<PagamentoDTO> Atualizar(PagamentoDTO pgto);
        Task<bool> Excluir(int id);
    }
}
