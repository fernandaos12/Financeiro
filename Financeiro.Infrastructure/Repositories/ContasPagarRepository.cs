using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Infrastructure.Repository
{
    public class ContasPagarRepository : IContasPagarRepository
    {
        private readonly AppDbContext _context;

        public ContasPagarRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Boolean> Atualizar(ContasPagar pagar)
        {
            var retorno = new Boolean();
            try
            {
                pagar.DataAlteracao = DateTime.Now.ToLocalTime();
                _context.ContasPagar.Update(pagar);
                await _context.SaveChangesAsync();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao atualizar: " + ex.Message);
            }

            return retorno;
        }

        public async Task<ContasPagar> FindId(int id)
        {
            var retorno = new ContasPagar();
            try
            {
                var item = await _context.ContasPagar.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id)
                    ?? throw new ArgumentException("Conta a pagar nao encontrada");

                retorno = item;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Conta a pagar nao encontrada: " + ex.Message);
            }

            return retorno;
        }

        public async Task<IEnumerable<ContasPagar>> ListarContas()
        {
            var retorno = new List<ContasPagar>();
            try
            {
                retorno = await _context.ContasPagar.ToListAsync() ?? throw new ArgumentException("Nenhuma conta a pagar encontrada.");
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Nenhuma conta a pagar encontrada: " + ex.Message);
            }

            return retorno;
        }

        public async Task<Boolean> Remover(int id)
        {
            try
            {
                var item = await _context.ContasPagar.FirstOrDefaultAsync(p => p.Id == id) ?? throw new ArgumentException("Conta a pagar nao encontrada.");

                _context.ContasPagar.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao remover conta a pagar: " + ex.Message);
            }

            return true;
        }

        public async Task<Boolean> Salvar(ContasPagar pagar)
        {
            byte[] anexopdf;
            string nomeArquivo = pagar.CaminhoAnexos ?? "anexoContaPagar";
            //IFormFile file;
            try
            {
                //var caminhoFisicoAnexo = ContasPagar.CaminhoAnexos;
                //var caminho = Directory.GetFiles(caminhoFisicoAnexo);
                if (nomeArquivo != null)
                {
                    string currentDirectory = Directory.GetCurrentDirectory();
                    if (!Directory.Exists(Path.Combine(currentDirectory, "tmp")))
                    {
                        Directory.CreateDirectory(Path.Combine(currentDirectory, "tmp"));
                    }

                    var arquivo = Directory.GetDirectories(Path.Combine(currentDirectory, "tmp", nomeArquivo));
                    //anexopdf = File.ReadAllBytes(ContasPagar.Anexos);
                    anexopdf = pagar.Anexos != null ? pagar.Anexos : throw new ArgumentNullException("Erro ao anexar arquivo.");
                    File.WriteAllBytes(nomeArquivo, anexopdf.ToArray());

                    pagar.Anexos = anexopdf.ToArray();
                }

                _context.ContasPagar.Add(pagar);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao salvar: " + e.Message);
            }
            return true;
        }

    }
}