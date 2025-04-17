using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Repository;

public interface IConfiguracoesRepository
{
    Task<IEnumerable<Configuracoes>> Listar();
    Task<Configuracoes> ObterporId(int id);
    Task<Boolean> Atualizar(Configuracoes config);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(Configuracoes config);
}
