using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces;

public interface IReceitasRepository
{
    Task<IEnumerable<Receitas>> Listar();
    Task<Receitas> FindId(int id);
    Task<Boolean> Atualizar(Receitas receitas);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(Receitas receitas);
}
