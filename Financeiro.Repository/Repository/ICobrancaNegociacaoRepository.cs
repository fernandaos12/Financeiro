using Financeiro.Domain.Entities;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICobrancaNegociacaoRepository
{
    Task<IEnumerable<Cobranca_Negociacao>> Listar();
    Task<Cobranca_Negociacao> FindId(int id);
    Task<Boolean> Atualizar(Cobranca_Negociacao cobranca);
    Task<Boolean> Remover(int id);
    Task<Boolean> Salvar(Cobranca_Negociacao cobranca);
}
