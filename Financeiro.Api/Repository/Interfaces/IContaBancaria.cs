using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IContaBancaria
{
  Task<IEnumerable<ContaBancaria>> GetAll();
    Task<ContaBancaria> FindId(int id);
    Task<bool> AtualizarItem(ContaBancaria conta);
    Task<bool> Remover(int id);
    Task<bool> Salvar(ContaBancaria conta);
}
