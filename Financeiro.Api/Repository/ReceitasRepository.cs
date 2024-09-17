using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class ReceitasRepository : IReceitas
{
    private readonly ApiDbcontext _context;
    public ReceitasRepository(ApiDbcontext context)
    {
        _context = context;
    }
    public async Task<bool> AtualizarItem(Receitas receita)
    {
        _context.Receitas.Update(receita);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Receitas> FindId(int id)
    {
        var item = await _context.Receitas.FirstOrDefaultAsync(p=>p.Id == id);
        if(item == null)
        {
            throw new ArgumentException("Não foi possível encontrar receita.");
        }
        return item;
    }

    public async Task<IEnumerable<Receitas>> GetAll()
    {
        List<Receitas> itens = await _context.Receitas.ToListAsync();
        return itens;
    }

    public async Task<bool> Remover(int id)
    {
       Receitas deletar = await FindId(id);
       _context.Receitas.Remove(deletar);
       await _context.SaveChangesAsync();
       return true;
    }

    public async Task<bool> Salvar(Receitas receita)
    {
        try
        {
            _context.Receitas.Add(receita);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {            
            throw new ArgumentException("Erro ao gravar na base de dados.");
        }
       
    }
}
