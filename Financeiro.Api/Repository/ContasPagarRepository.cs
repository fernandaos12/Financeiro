using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
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
        public async void Atualizar(ContasPagar cp)
        {
            _context.contasPagar.Update(cp);
            await _context.SaveChangesAsync();
        }

        public async Task<ContasPagar> FindId(int id)
        {
            var item = await _context.contasPagar.FirstOrDefaultAsync(p=>p.Id == id);

            if(item == null){
                throw new ArgumentNullException("Item Not Found - 404 ");
            }
            return item;
        }

        public async Task<IEnumerable<ContasPagar>> ListarContas()
        {           
            List<ContasPagar> contaslistar = await _context.contasPagar.ToListAsync();
            return contaslistar;
        }

        public async Task<bool> Remover(int id)
        {

            ContasPagar contadeletar = await FindId(id);

            if(contadeletar == null){                
                return false;
            }
            
            _context.contasPagar.Remove(contadeletar);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Salvar(ContasPagar cp)
        {
            try{
            _context.contasPagar.Add(cp);
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