using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IReceitas
{
    Task<ServiceResponse<IEnumerable<Receitas>>> Listar();
    Task<ServiceResponse<Receitas>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(Receitas receitas);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(Receitas receitas);
}
