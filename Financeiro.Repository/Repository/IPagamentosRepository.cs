using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Repository;

public interface IPagamentosRepository
{
    Task<IEnumerable<Pagamento>> Listar();
    Task<Pagamento> FindId(int id);
    Task<Boolean> Atualizar(Pagamento pag);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(Pagamento pag);

}
