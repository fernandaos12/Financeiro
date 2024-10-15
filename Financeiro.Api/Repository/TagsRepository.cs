using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
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
        public async void Atualizar(Tags cp)
        {
            _context.Tags.Update(cp);
            await _context.SaveChangesAsync();
        }

        public async Task<Tags> FindId(int id)
        {
            var item = await _context.Tags.FirstOrDefaultAsync(p=>p.Id == id);

            if(item == null){
                throw new ArgumentNullException("Item Not Found - 404 ");
            }
            return item;
        }

        public async Task<IEnumerable<Tags>> ListarContas()
        {           
            List<Tags> contaslistar = await _context.Tags.ToListAsync();
            return contaslistar;
        }

        public async Task<bool> Remover(int id)
        {

            Tags contadeletar = await FindId(id);

            if(contadeletar == null){                
                return false;
            }
            
            _context.Tags.Remove(contadeletar);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Salvar(Tags cp)
        {
            try{
            _context.Tags.Add(cp);
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