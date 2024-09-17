using System;
using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class PagamentosRepository : IPagamentos
{
    private readonly ApiDbcontext _context;
    public PagamentosRepository(ApiDbcontext context)
    {
        _context = context;
    }

    public async Task<bool> AtualizarItem(Pagamento pag)
    {      
        _context.Pagamentos.Update(pag);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Pagamento> FindId(int id)
    {
        var item = await _context.Pagamentos.FirstOrDefaultAsync(p=>p.Id == id);

            if(item == null){
                throw new ArgumentNullException("Item Not Found - 404 ");
            }
            return item;
    }

    public async Task<IEnumerable<Pagamento>> GetAll()
    {
        List<Pagamento> listar = await _context.Pagamentos.ToListAsync();
        return listar;
    }

    public async Task<bool> Remover(int id)
    {
        Pagamento deletar = await FindId(id);

            if(deletar == null){                
                return false;
            }
            
            _context.Pagamentos.Remove(deletar);
            await _context.SaveChangesAsync();
            return true;
    }

    public async Task<bool> Salvar(Pagamento pag)
    {
        try{
            _context.Pagamentos.Add(pag);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(Exception)
        {
            throw new Exception("Erro ao gravar na base de dados");
        }
    }
}
