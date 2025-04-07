using Financeiro.Api.Models.DTO;

namespace Financeiro.Api.Services.Interfaces
{
    public interface IContasPagarDTO
    {
        Task<List<ContasPagarDTO>> Listar();
        Task<ContasPagarDTO> BuscarPorId(int id);
        Task<ContasPagarDTO> Cadastrar(ContasPagarDTO contasPagar);
        Task<ContasPagarDTO> Atualizar(ContasPagarDTO contasPagar);
        Task<bool> Excluir(int id);
    }

}
