using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IContaBancaria
{
    Task<ServiceResponse<IEnumerable<ContaBancaria>>> Listar();
    Task<ServiceResponse<ContaBancaria>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(ContaBancaria conta);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(ContaBancaria conta);
}
