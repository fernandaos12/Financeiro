using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IPagamentos
{
    Task<ServiceResponse<IEnumerable<Pagamento>>> Listar();
    Task<ServiceResponse<Pagamento>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(Pagamento pag);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(Pagamento pag);

}
