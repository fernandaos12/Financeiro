using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class ConfiguracoesRepository : IConfiguracoes
{
    private readonly ApiDbcontext _context;
    public ConfiguracoesRepository(ApiDbcontext context)
    {
        _context = context;
    }
    public async Task<bool> AtualizarItem(Configuracoes config)
    {
        _context.Configuracoes.Update(config);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Configuracoes> FindId(int id)
    {
        var item = await _context.Configuracoes.FirstOrDefaultAsync(p=>p.Id == id);    
        
        if(item == null)
        {
             throw new ArgumentNullException("Item Not Found - 404 ");
        }
        
        return item;
    }

    public async Task<IEnumerable<Configuracoes>> GetAll()
    {
        List<Configuracoes> lista = await _context.Configuracoes.ToListAsync();
        return lista;
    }

    public async Task<bool> Remover(int id)
    {
        Configuracoes deletar = await FindId(id);
        if(deletar == null){
            return false;
        }
        _context.Configuracoes.Remove(deletar);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Salvar(Configuracoes config)
    {
       try
       {
         _context.Configuracoes.Add(config);
         await _context.SaveChangesAsync();
         return true;

       }
       catch (System.Exception)
       {        
           throw new Exception("Erro ao gravar na base de dados.");
       }
    }
}
