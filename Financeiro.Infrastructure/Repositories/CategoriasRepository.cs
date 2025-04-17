using Financeiro.Api.Repository.Interfaces;
using Financeiro.Domain.Entities;
using Financeiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository
{
    public class CategoriasRepository : ICategoriasRepository
    {
        private readonly AppDbContext _context;
        public CategoriasRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Boolean> Atualizar(Categorias categoria)
        {
            try
            {
                var item = await _context.Categorias
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == categoria.Id)
                    ?? throw new ArgumentException("Categoria não encontrada");

                _context.Categorias.Update(categoria);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao atualizar: " + ex.Message);
            }
            return true;
        }

        public async Task<Categorias> FindId(int id)
        {
            var item = await _context.Categorias.FirstOrDefaultAsync(p => p.Id == id)
                               ?? throw new ArgumentException("Categoria não encontrada");
            return item;
        }

        public async Task<IEnumerable<Categorias>> Listar()
        {
            var retorno = new List<Categorias>();
            retorno = await _context.Categorias.ToListAsync() ?? throw new ArgumentException("Nenhuma conta a receber encontrada.");

            return retorno;
        }

        public async Task<Boolean> Remover(int id)
        {
            var item = await _context.Categorias.FirstOrDefaultAsync(p => p.Id == id)
                                ?? throw new ArgumentException("Categoria não encontrada"); ;

            _context.Categorias.Remove(item);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Boolean> Salvar(Categorias Categorias)
        {
            try
            {
                _context.Categorias.Add(Categorias);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Erro ao salvar + " + e.Message);
            }
        }
    }
}