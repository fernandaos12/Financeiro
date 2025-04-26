using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Repository;
public interface ICobrancasRepository
{
    Task<IEnumerable<Cobrancas>> Listar(); // IEnumerable<Cobranca>
    Task<Cobrancas> BuscarCobrancaItem(int id);
    Task<bool> GravarCobranca(Cobrancas cobranca);
    Task<bool> AlterarCobranca(Cobrancas cobranca);
    Task<bool> ExcluirCobranca(int id);

}

