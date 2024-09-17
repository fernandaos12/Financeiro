using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class CobrancaNegociacaoRepository : ICobrancaNegociacao
{
    private readonly ApiDbcontext _context;
    public CobrancaNegociacaoRepository(ApiDbcontext context)
    {
        _context = context;
    }

    public async Task<bool> AtualizarItem(Cobranca_Negociacao cobranca)
    {
         _context.CobrancaNegociacao.Update(cobranca);
         await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Cobranca_Negociacao> FindId(int id)
    {
        var item = await _context.CobrancaNegociacao.FirstOrDefaultAsync(p=>p.Id == id);

        if(item == null){
            throw new ArgumentNullException("Item Not Found - 404 ");
        }
        return item;
    }

    public async Task<IEnumerable<Cobranca_Negociacao>> GetAll()
    {
        List<Cobranca_Negociacao> lista = await  _context.CobrancaNegociacao.ToListAsync();
        return lista;
    }

    public async Task<bool> Remover(int id)
    {
        Cobranca_Negociacao deletar = await FindId(id);
        if(deletar == null){
            return false;
        }
         _context.CobrancaNegociacao.Remove(deletar);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Salvar(Cobranca_Negociacao cobranca)
    {
        try
        {
            _context.CobrancaNegociacao.Add(cobranca);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {            
            throw new Exception("Erro ao gravar item.");
        }
    }
}
