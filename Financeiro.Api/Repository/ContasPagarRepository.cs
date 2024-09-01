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
        public void Atualizar(ContasPagar cp)
        {
            throw new NotImplementedException();
        }

        public async Task<ContasPagar> FindId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContasPagar>> ListarContas()
        {
            return await _context.contasPagar.ToListAsync();
        }

        public async Task<bool> Remover(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Salvar(ContasPagar cp)
        {
            throw new NotImplementedException();
        }
    }
}