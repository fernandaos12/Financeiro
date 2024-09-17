using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Api.Repository
{
    public class ContasReceberRepository : IContasReceber
    {
        private readonly ApiDbcontext _context;
        public ContasReceberRepository(ApiDbcontext context)
        {
            _context = context;
        }

        public async Task<bool> Atualizar(ContasReceber cr)
        {
            try
            {
                _context.ContasReceber.Update(cr);
                await _context.SaveChangesAsync();
                return true;
                
            }
            catch (System.Exception)
            {                
                throw new ArgumentException("Erro ao atualizar item no banco de dados.");
            }
        }

        public async Task<ContasReceber> FindId(int id)
        {
           var item = await _context.ContasReceber.FirstOrDefaultAsync(p=>p.Id == id);
           if(item == null)
           {
                throw new ArgumentException("Conta a receber não existe no banco de dados.");
           }
           return item;
        }

        public async Task<IEnumerable<ContasReceber>> ListarContas()
        {
            List<ContasReceber> contas = await _context.ContasReceber.ToListAsync();
            return contas;
        }

        public async Task<bool> Remover(int id)
        {
            ContasReceber obj = await FindId(id);
            _context.ContasReceber.Remove(obj);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Salvar(ContasReceber cr)
        {
            try
            {
                _context.ContasReceber.Add(cr);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {                
                throw new ArgumentException("Erro ao gravar conta a receber no banco de dados.");
            }
        }
    }
}