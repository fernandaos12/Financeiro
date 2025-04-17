using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class PagamentosRepository : IPagamentosRepository
{
    private readonly AppDbContext _context;
    public PagamentosRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Boolean> Atualizar(Pagamento receber)
    {
        Pagamento item = await _context.Pagamentos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id)
            ?? throw new ArgumentException("Conta a receber nao encontrada");

        item.DataAlteracao = DateTime.Now.ToLocalTime();
        _context.Pagamentos.Update(receber);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Pagamento> FindId(int id)
    {
        Pagamento item = await _context.Pagamentos.FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new ArgumentException("Conta a receber nao encontrada");
        return item;
    }

    public async Task<IEnumerable<Pagamento>> Listar()
    {
        var retorno = await _context.Pagamentos.ToListAsync()
            ?? throw new ArgumentException("Nenhuma conta a receber encontrada.");
        return retorno;
    }

    public async Task<Boolean> Remover(int id)
    {
        Pagamento item = await _context.Pagamentos.FirstOrDefaultAsync(p => p.Id == id)
        ?? throw new ArgumentException("Conta a receber nao encontrada");

        _context.Pagamentos.Remove(item);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<Boolean> Salvar(Pagamento Pagamentos)
    {
        try
        {
            _context.Pagamentos.Add(Pagamentos);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            throw new ArgumentException("Erro ao gravar + " + e.Message);
        }
    }
}
