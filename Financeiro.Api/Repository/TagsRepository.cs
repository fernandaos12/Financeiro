using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository
{
    public class TagsRepository : ITags
    {
        private readonly ApiDbcontext _context;
        public TagsRepository(ApiDbcontext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Boolean>> Atualizar(Tags receber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                Tags item = await _context.Tags.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id);
                if (item == null)
                {
                    retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                    retorno.Sucesso = false;
                }

                item.DataAlteracao = DateTime.Now.ToLocalTime();
                _context.Tags.Update(receber);
                await _context.SaveChangesAsync();
                retorno.DadosRetorno = true;

            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }
            return retorno;
        }

        public async Task<ServiceResponse<Tags>> FindId(int id)
        {
            var retorno = new ServiceResponse<Tags>();
            try
            {
                Tags item = await _context.Tags.FirstOrDefaultAsync(p => p.Id == id);
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

        public async Task<ServiceResponse<IEnumerable<Tags>>> Listar()
        {
            var retorno = new ServiceResponse<IEnumerable<Tags>>();
            try
            {
                retorno.DadosRetorno = await _context.Tags.ToListAsync();
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
                Tags item = await _context.Tags.FirstOrDefaultAsync(p => p.Id == id);

                _context.Tags.Remove(item);
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

        public async Task<ServiceResponse<Boolean>> Salvar(Tags Tags)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                _context.Tags.Add(Tags);
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
}