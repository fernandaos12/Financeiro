using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IPagamentos
{
    Task<IEnumerable<Pagamento>> GetAll();
    Task<Pagamento> FindId(int id);
    Task<bool> AtualizarItem(Pagamento pag);
    Task<bool> Remover(int id);
    Task<bool> Salvar(Pagamento pag);

}
