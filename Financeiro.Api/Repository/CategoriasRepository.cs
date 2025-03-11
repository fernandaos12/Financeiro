using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository
{
    public class CategoriasRepository : ICategorias
    {
        private readonly ApiDbcontext _context;
        public CategoriasRepository(ApiDbcontext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Boolean>> Atualizar(CategoriaReceitas receber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                CategoriaReceitas item = await _context.Categorias.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id);
                if (item == null)
                {
                    retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                    retorno.Sucesso = false;
                }

                item.DataAlteracao = DateTime.Now.ToLocalTime();
                _context.Categorias.Update(receber);
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

        public async Task<ServiceResponse<CategoriaReceitas>> FindId(int id)
        {
            var retorno = new ServiceResponse<CategoriaReceitas>();
            try
            {
                CategoriaReceitas item = await _context.Categorias.FirstOrDefaultAsync(p => p.Id == id);
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

        public async Task<ServiceResponse<IEnumerable<CategoriaReceitas>>> Listar()
        {
            var retorno = new ServiceResponse<IEnumerable<CategoriaReceitas>>();
            try
            {
                retorno.DadosRetorno = await _context.Categorias.ToListAsync();
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
                CategoriaReceitas item = await _context.Categorias.FirstOrDefaultAsync(p => p.Id == id);

                _context.Categorias.Remove(item);
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

        public async Task<ServiceResponse<Boolean>> Salvar(CategoriaReceitas Categorias)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                _context.Categorias.Add(Categorias);
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