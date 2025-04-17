using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces;

public interface IContaBancariaRepository
{
    Task<IEnumerable<ContaBancaria>> Listar();
    Task<ContaBancaria> FindId(int id);
    Task<Boolean> Atualizar(ContaBancaria conta);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(ContaBancaria conta);
}
