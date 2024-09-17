using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IReceitas
{
    Task<IEnumerable<Receitas>> GetAll();
    Task<Receitas> FindId(int id);
    Task<bool> AtualizarItem(Receitas receitas);
    Task<bool> Remover(int id);
    Task<bool> Salvar(Receitas receitas);
}
