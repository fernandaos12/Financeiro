using System;
using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class CartaoCreditoRepository : ICartaoCredito
{
     private readonly ApiDbcontext _context;
    public CartaoCreditoRepository(ApiDbcontext context)
    {
        _context = context;
    }
    public async Task<bool> AtualizarItem(CartaoCredito cartao)
    {
        _context.CartaoCredito.Update(cartao);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<CartaoCredito> FindId(int id)
    {
        var item = await _context.CartaoCredito.FirstOrDefaultAsync(p=>p.Id == id);

            if(item == null){
                throw new ArgumentNullException("Item Not Found - 404 ");
            }
            return item;
    }

    public async Task<IEnumerable<CartaoCredito>> GetAll()
    {
        List<CartaoCredito> listar = await _context.CartaoCredito.ToListAsync();
        return listar;
    }

    public async Task<bool> Remover(int id)
    {
         CartaoCredito deletar = await FindId(id);

            if(deletar == null){                
                return false;
            }                        
            _context.CartaoCredito.Remove(deletar);
            await _context.SaveChangesAsync();
            return true;
    }

    public async Task<bool> Salvar(CartaoCredito cartao)
    {
        try{
            _context.CartaoCredito.Add(cartao);
            await _context.SaveChangesAsync();
            return true;
            }
            catch(Exception)
            {
                throw new Exception("Erro ao gravar na base de dados");
            }
    }
}
