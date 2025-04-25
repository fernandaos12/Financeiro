using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Infrastructure.Repository
{
    public class ContasPagarRepository : IContasPagarRepository
    {
        private readonly IDbContextFactory<AppDbContext> _context;

        public ContasPagarRepository(IDbContextFactory<AppDbContext> context)
        {
            _context = context;
        }

        public async Task<Boolean> Atualizar(ContasPagar pagar)
        {
            try
            {
                using (var con = _context.CreateDbContext())
                {
                    con.ContasPagar.Update(pagar);
                    await con.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao atualizar: " + ex.Message);
            }
        }

        public async Task<ContasPagar> FindId(int id)
        {
            var retorno = new ContasPagar();
            try
            {
                using (var con = _context.CreateDbContext())
                {
                    var item = await con.ContasPagar
                        .AsNoTracking().FirstOrDefaultAsync(p => p.Id == id)
                    ?? throw new ArgumentException("Conta a pagar nao encontrada");

                    retorno = item;
                }
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
                using (var con = _context.CreateDbContext())
                {
                    retorno = await con.ContasPagar.ToListAsync()
                        ?? throw new ArgumentException("Nenhuma conta a pagar encontrada.");
                }
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
                using (var con = _context.CreateDbContext())
                {
                    var item = await con.ContasPagar.FirstOrDefaultAsync(p => p.Id == id) ?? throw new ArgumentException("Conta a pagar nao encontrada.");

                    con.ContasPagar.Remove(item);
                    await con.SaveChangesAsync();
                }
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
            string nomeArquivo = "anexoContaPagar_" + pagar.Descricao?.Replace(" ", "_") + ".pdf";

            try
            {
                using (var con = _context.CreateDbContext())
                {
                    if (nomeArquivo != null)
                    {
                        string currentDirectory = Directory.GetCurrentDirectory();
                        if (!Directory.Exists(Path.Combine(currentDirectory, "tmp")))
                        {
                            Directory.CreateDirectory(Path.Combine(currentDirectory, "tmp"));
                        }

                        anexopdf = pagar.Anexos != null ? pagar.Anexos : throw new ArgumentNullException("Erro ao anexar arquivo.");
                        string caminho_arquivo = Path.Combine(currentDirectory, "tmp", nomeArquivo);

                        File.WriteAllBytes(caminho_arquivo, anexopdf.ToArray());

                        pagar.Anexos = anexopdf.ToArray();
                        pagar.CaminhoAnexos = caminho_arquivo;
                    }

                    con.ContasPagar.Add(pagar);
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
}