using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICobrancaNegociacao
{
  Task<IEnumerable<Cobranca_Negociacao>> GetAll();
    Task<Cobranca_Negociacao> FindId(int id);
    Task<bool> AtualizarItem(Cobranca_Negociacao cobranca);
    Task<bool> Remover(int id);
    Task<bool> Salvar(Cobranca_Negociacao cobranca);
}
