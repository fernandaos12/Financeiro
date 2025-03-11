using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository;

public class PagamentosRepository : IPagamentos
{
    private readonly ApiDbcontext _context;
    public PagamentosRepository(ApiDbcontext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<Boolean>> Atualizar(Pagamento receber)
    {
        var retorno = new ServiceResponse<Boolean>();
        try
        {
            Pagamento item = await _context.Pagamentos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id);
            if (item == null)
            {
                retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                retorno.Sucesso = false;
            }
            else
            {
                item.DataAlteracao = DateTime.Now.ToLocalTime();
                _context.Pagamentos.Update(receber);
                await _context.SaveChangesAsync();
                retorno.DadosRetorno = true;
            }

        }
        catch (Exception ex)
        {
            retorno.Mensagem = ex.Message;
            retorno.Sucesso = false;
        }
        return retorno;
    }

    public async Task<ServiceResponse<Pagamento>> FindId(int id)
    {
        var retorno = new ServiceResponse<Pagamento>();
        try
        {
            Pagamento item = await _context.Pagamentos.FirstOrDefaultAsync(p => p.Id == id);
            retorno.DadosRetorno = item;

            if (item == null)
            {
                retorno.DadosRetorno = null;
                retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                retorno.Sucesso = false;
            }

        }
        catch (Exception ex)
        {
            retorno.Mensagem = ex.Message;
            retorno.Sucesso = false;
        }
        return retorno;
    }

    public async Task<ServiceResponse<IEnumerable<Pagamento>>> Listar()
    {
        var retorno = new ServiceResponse<IEnumerable<Pagamento>>();
        try
        {
            retorno.DadosRetorno = await _context.Pagamentos.ToListAsync();
            if (retorno.DadosRetorno == null)
            {
                retorno.Mensagem = "Nenhuma conta a receber encontrada.";
            }

        }
        catch (Exception ex)
        {
            retorno.Mensagem = ex.Message;
            retorno.Sucesso = false;
        }
        return retorno;
    }

    public async Task<ServiceResponse<Boolean>> Remover(int id)
    {
        var retorno = new ServiceResponse<Boolean>();
        try
        {
            Pagamento item = await _context.Pagamentos.FirstOrDefaultAsync(p => p.Id == id);

            _context.Pagamentos.Remove(item);
            await _context.SaveChangesAsync();

            retorno.DadosRetorno = true;
            retorno.Mensagem = "Conta a receber removida com sucesso.";


        }
        catch (Exception ex)
        {
            retorno.Mensagem = $@"Erro ao remover conta a receber. {ex.Message}";
            retorno.Sucesso = false;
        }

        return retorno;
    }
    /// <summary>
    /// Método responsável por gravar os dados  
    /// </summary>
    /// <param name="Pagamentos"></param>
    /// <returns>boolean</returns>
    public async Task<ServiceResponse<Boolean>> Salvar(Pagamento Pagamentos)
    {
        var retorno = new ServiceResponse<Boolean>();
        try
        {

            _context.Pagamentos.Add(Pagamentos);
            await _context.SaveChangesAsync();
            retorno.DadosRetorno = true;
            retorno.Mensagem = "Dados gravados com sucesso.";
        }
        catch (Exception e)
        {
            retorno.Mensagem = $@"Erro ao gravar conta a receber no banco de dados. {e.Message}";
        }
        return retorno;
    }
}
