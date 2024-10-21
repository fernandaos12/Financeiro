using Financeiro.Api.Models;
using Financeiro.Api.Repository.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICobrancaNegociacao
{
    Task<ServiceResponse<IEnumerable<Cobranca_Negociacao>>> Listar();
    Task<ServiceResponse<Cobranca_Negociacao>> FindId(int id);
    Task<ServiceResponse<Boolean>> Atualizar(Cobranca_Negociacao cobranca);
    Task<ServiceResponse<Boolean>> Remover(int id);
    Task<ServiceResponse<Boolean>> Salvar(Cobranca_Negociacao cobranca);
}
