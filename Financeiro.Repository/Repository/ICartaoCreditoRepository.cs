using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICartaoCreditoRepository
{
    Task<IEnumerable<CartaoCreditoDTO>> Listar();
    Task<CartaoCreditoDTO> FindId(int id);
    Task<Boolean> Atualizar(CartaoCreditoDTO cartao);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(CartaoCreditoDTO cartao);

}
