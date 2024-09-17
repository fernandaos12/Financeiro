using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class ContaBancariaRepository : IContaBancaria
{
    private readonly ApiDbcontext _context;
    public ContaBancariaRepository(ApiDbcontext context)
    {
        _context = context;
    }
    public async Task<bool> AtualizarItem(ContaBancaria conta)
    {
       _context.ContaBancaria.Update(conta);
       await _context.SaveChangesAsync();
       return true;
    }

    public async Task<ContaBancaria> FindId(int id)
    {
        var item = await _context.ContaBancaria.FirstOrDefaultAsync(p=>p.Id == id);
        if(item == null){
            throw new ArgumentException("Conta bancária não encontrada.");
        }
        return item;
    }

    public async Task<IEnumerable<ContaBancaria>> GetAll()
    {
        List<ContaBancaria> lista = await _context.ContaBancaria.ToListAsync();
        return lista;
    }

    public async Task<bool> Remover(int id)
    {
        ContaBancaria deletar = await FindId(id);
        if(deletar == null){
            throw new ArgumentException("Conta bancária não encontrada");
        }
        _context.ContaBancaria.Remove(deletar);
        await  _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> Salvar(ContaBancaria conta)
    {
       try
       {
            _context.ContaBancaria.Add(conta);
            await _context.SaveChangesAsync();
            return true;
       }
       catch (System.Exception)
       {        
            throw new ArgumentException("Erro ao gravar na base de dados.");
       }
    }
}
