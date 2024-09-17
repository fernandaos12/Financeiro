using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface IConfiguracoes
{
    Task<IEnumerable<Configuracoes>> GetAll();
    Task<Configuracoes> FindId(int id);
    Task<bool> AtualizarItem(Configuracoes config);
    Task<bool> Remover(int id);
    Task<bool> Salvar(Configuracoes config);

}
