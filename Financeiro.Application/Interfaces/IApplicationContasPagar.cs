using Financeiro.Application.Models.DTO;

namespace Financeiro.Application.Interfaces
{
    public interface IApplicationContasPagar
    {
        Task<IEnumerable<ContasPagarDTO>> ListarContas();
        Task<ContasPagarDTO> FindId(int id);
        Task<Boolean> Salvar(ContasPagarDTO contaspagar);
        Task<Boolean> Atualizar(ContasPagarDTO contaspagar);
        Task<Boolean> Remover(int id);
    }
}
