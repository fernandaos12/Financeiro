using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class CobrancaRepository : ICobrancasRepository
{
    private readonly IDbContextFactory<AppDbContext> _context;
    public CobrancaRepository(IDbContextFactory<AppDbContext> context)
    {
        _context = context;
    }

    public async Task<Boolean> AlterarCobranca(Cobrancas cobranca)
    {
        try
        {
            using (var con = _context.CreateDbContext())
            {
                con.Cobranca.Update(cobranca);
                await con.SaveChangesAsync();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Erro ao atualizar: " + ex.Message);
        }
    }

    public async Task<Cobrancas> BuscarCobrancaItem(int id)
    {
        var retorno = new Cobrancas();
        try
        {
            using (var con = _context.CreateDbContext())
            {
                var item = await con.Cobranca
                    .AsNoTracking().FirstOrDefaultAsync(p => p.Id == id)
                ?? throw new ArgumentException("Cobrança não encontrada");

                retorno = item;
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Cobrança não encontrada: " + ex.Message);
        }

        return retorno;
    }

    public async Task<IEnumerable<Cobrancas>> Listar()
    {
        var retorno = new List<Cobrancas>();
        try
        {
            using (var con = _context.CreateDbContext())
            {
                retorno = await con.Cobranca.ToListAsync()
                    ?? throw new ArgumentException("Nenhuma cobrança encontrada.");
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Nenhuma cobrança encontrada: " + ex.Message);
        }

        return retorno;
    }

    public async Task<Boolean> ExcluirCobranca(int id)
    {
        try
        {
            using (var con = _context.CreateDbContext())
            {
                var item = await con.Cobranca.FirstOrDefaultAsync(p => p.Id == id)
                    ?? throw new ArgumentException("Cobrança não  encontrada.");

                con.Cobranca.Remove(item);
                await con.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Erro ao remover cobrança: " + ex.Message);
        }

        return true;
    }

    public async Task<Boolean> GravarCobranca(Cobrancas cobranca)
    {
        try
        {
            using (var con = _context.CreateDbContext())
            {
                con.Cobranca.Add(cobranca);
                await con.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            throw new Exception("Erro ao salvar: " + e.Message);
        }
        return true;
    }
}