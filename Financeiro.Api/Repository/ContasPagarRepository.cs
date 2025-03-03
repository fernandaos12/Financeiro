using System.Text;
using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository
{
    public class ContasPagarRepository : IContasPagar
    {
        private readonly ApiDbcontext _context;

        public ContasPagarRepository(ApiDbcontext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Boolean>> Atualizar(ContasPagar receber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                ContasPagar item =
                    await _context.contasPagar.AsNoTracking().FirstOrDefaultAsync(p => p.Id == receber.Id);
                if (item == null)
                {
                    retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                    retorno.Sucesso = false;
                }

                item.DataAlteracao = DateTime.Now.ToLocalTime();
                _context.contasPagar.Update(receber);
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

        public async Task<ServiceResponse<ContasPagar>> FindId(int id)
        {
            var retorno = new ServiceResponse<ContasPagar>();
            try
            {
                ContasPagar item = await _context.contasPagar.FirstOrDefaultAsync(p => p.Id == id);
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

        public async Task<ServiceResponse<IEnumerable<ContasPagar>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ContasPagar>>();
            try
            {
                retorno.DadosRetorno = await _context.contasPagar.ToListAsync();
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
                ContasPagar item = await _context.contasPagar.FirstOrDefaultAsync(p => p.Id == id);

                _context.contasPagar.Remove(item);
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

        public async Task<ServiceResponse<Boolean>> Salvar(ContasPagar contaspagar)
        {
            var retorno = new ServiceResponse<Boolean>();
            byte[] anexopdf;
            string nomeArquivo = contaspagar.CaminhoAnexos;
            IFormFile file;
           
            try
            {
                //var caminhoFisicoAnexo = contaspagar.CaminhoAnexos;
                //var caminho = Directory.GetFiles(caminhoFisicoAnexo);
                if (nomeArquivo != null)
                {
                    string currentDirectory = Directory.GetCurrentDirectory();
                    if (!Directory.Exists(Path.Combine(currentDirectory, "tmp")))
                    {
                        Directory.CreateDirectory(Path.Combine(currentDirectory, "tmp"));
                    }

                    var arquivo = Directory.GetDirectories(Path.Combine(currentDirectory, "tmp", nomeArquivo));
                    //anexopdf = File.ReadAllBytes(contaspagar.Anexos);
                    anexopdf = contaspagar.Anexos;
                    File.WriteAllBytes(nomeArquivo, anexopdf.ToArray());
                    
                    contaspagar.Anexos = anexopdf.ToArray();
                }

                _context.contasPagar.Add(contaspagar);
                await _context.SaveChangesAsync();
                
                retorno.DadosRetorno = true;
                retorno.Mensagem = "Dados gravados com sucesso.";
            }
            catch (Exception e)
            {
                retorno.Mensagem = $@"Erro ao gravar conta a pagar no banco de dados :  {e.Message}";
            }
            return retorno;
        }
    }
}