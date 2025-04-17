namespace Financeiro.Api.Repository;

//public class CobrancaNegociacaoRepository : ICobrancaNegociacao
//{
//    private readonly ApiDbcontext _context;
//    public CobrancaNegociacaoRepository(ApiDbcontext context)
//    {
//        _context = context;
//    }

//    public async Task<ServiceResponse<Boolean>> Atualizar(Cobranca_Negociacao receber)
//    {
//        var retorno = new ServiceResponse<Boolean>();
//        try
//        {
//            Cobranca_Negociacao item = await _context.CobrancaNegociacao.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id);
//            if (item == null)
//            {
//                retorno.Mensagem = "Conta a receber não existe no banco de dados.";
//                retorno.Sucesso = false;
//            }

//            item.DataAlteracao = DateTime.Now.ToLocalTime();
//            _context.CobrancaNegociacao.Update(receber);
//            await _context.SaveChangesAsync();
//            retorno.DadosRetorno = true;

//        }
//        catch (Exception ex)
//        {
//            retorno.Mensagem = ex.Message;
//            retorno.Sucesso = false;
//        }
//        return retorno;
//    }

//    public async Task<ServiceResponse<Cobranca_Negociacao>> FindId(int id)
//    {
//        var retorno = new ServiceResponse<Cobranca_Negociacao>();
//        try
//        {
//            Cobranca_Negociacao item = await _context.CobrancaNegociacao.FirstOrDefaultAsync(p => p.Id == id);
//            retorno.DadosRetorno = item;

//            if (item == null)
//            {
//                retorno.DadosRetorno = null;
//                retorno.Mensagem = "Conta a receber não existe no banco de dados.";
//                retorno.Sucesso = false;
//            }

//        }
//        catch (Exception ex)
//        {
//            retorno.Mensagem = ex.Message;
//            retorno.Sucesso = false;
//        }
//        return retorno;
//    }

//    public async Task<ServiceResponse<IEnumerable<Cobranca_Negociacao>>> Listar()
//    {
//        var retorno = new ServiceResponse<IEnumerable<Cobranca_Negociacao>>();
//        try
//        {
//            retorno.DadosRetorno = await _context.CobrancaNegociacao.ToListAsync();
//            if (retorno.DadosRetorno == null)
//            {
//                retorno.Mensagem = "Nenhuma conta a receber encontrada.";
//            }

//        }
//        catch (Exception ex)
//        {
//            retorno.Mensagem = ex.Message;
//            retorno.Sucesso = false;
//        }
//        return retorno;
//    }

//    public async Task<ServiceResponse<Boolean>> Remover(int id)
//    {
//        var retorno = new ServiceResponse<Boolean>();
//        try
//        {
//            Cobranca_Negociacao item = await _context.CobrancaNegociacao.FirstOrDefaultAsync(p => p.Id == id);

//            _context.CobrancaNegociacao.Remove(item);
//            await _context.SaveChangesAsync();

//            retorno.DadosRetorno = true;
//            retorno.Mensagem = "Conta a receber removida com sucesso.";


//        }
//        catch (Exception ex)
//        {
//            retorno.Mensagem = $@"Erro ao remover conta a receber. {ex.Message}";
//            retorno.Sucesso = false;
//        }

//        return retorno;
//    }

//    public async Task<ServiceResponse<Boolean>> Salvar(Cobranca_Negociacao CobrancaNegociacao)
//    {
//        var retorno = new ServiceResponse<Boolean>();
//        try
//        {
//            _context.CobrancaNegociacao.Add(CobrancaNegociacao);
//            await _context.SaveChangesAsync();
//            retorno.DadosRetorno = true;
//            retorno.Mensagem = "Dados gravados com sucesso.";
//        }
//        catch (Exception e)
//        {
//            retorno.Mensagem = $@"Erro ao gravar conta a receber no banco de dados. {e.Message}";
//        }
//        return retorno;
//    }


//}
