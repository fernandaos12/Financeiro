using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICartaoCreditoRepository
{
    Task<IEnumerable<CartaoCredito>> Listar();
    Task<CartaoCredito> FindId(int id);
    Task<Boolean> Atualizar(CartaoCredito cartao);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(CartaoCredito cartao);

}
