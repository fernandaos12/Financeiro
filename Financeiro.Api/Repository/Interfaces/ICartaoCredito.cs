using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICartaoCredito 
{
    Task<ServiceResponse<IEnumerable<CartaoCredito>>> Listar();
    Task<ServiceResponse<CartaoCredito>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(CartaoCredito cartao);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(CartaoCredito cartao);

}
