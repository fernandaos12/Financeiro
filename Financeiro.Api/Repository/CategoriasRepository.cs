using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
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
        public async Task<bool> Atualizar(Categorias categoria)
        {
           _context.Categorias.Update(categoria);
           await _context.SaveChangesAsync();
           return true;
        }

        public async Task<Categorias> FindId(int id)
        {
             var item = await _context.Categorias.FirstOrDefaultAsync(p=>p.Id == id);

            if(item == null){
                throw new ArgumentNullException("Item Not Found - 404 ");
            }
            return item;
        }

        public async Task<IEnumerable<Categorias>> Listar()
        {
            List<Categorias> lista = await _context.Categorias.ToListAsync();
            return lista;
        }

        public async Task<bool> Remover(int id)
        {
           Categorias deletar = await FindId(id);

            if(deletar == null){                
                return false;
            }                        
            _context.Categorias.Remove(deletar);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Salvar(Categorias categoria)
        {
            try{
                _context.Categorias.Add(categoria);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                throw new Exception("Erro ao gravar na base de dados");
            }
        }
    }
}