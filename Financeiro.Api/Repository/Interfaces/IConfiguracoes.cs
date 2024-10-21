using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IConfiguracoes
{
    Task<ServiceResponse<IEnumerable<Configuracoes>>> Listar();
    Task<ServiceResponse<Configuracoes>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(Configuracoes config);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(Configuracoes config);

}
