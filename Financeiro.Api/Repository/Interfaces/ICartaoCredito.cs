using System;
using Financeiro.Api.Models;

namespace Financeiro.Api.Repository.Interfaces;

public interface ICartaoCredito 
{
    Task<IEnumerable<CartaoCredito>> GetAll();
    Task<CartaoCredito> FindId(int id);
    Task<bool> AtualizarItem(CartaoCredito cartao);
    Task<bool> Remover(int id);
    Task<bool> Salvar(CartaoCredito cartao);

}
