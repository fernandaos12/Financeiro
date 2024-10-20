using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Data;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
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

        public async Task<ServiceResponse<Boolean>> Atualizar(ContasReceber receber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                ContasReceber item = await _context.ContasReceber.AsNoTracking().FirstOrDefaultAsync(p=>p.Id == receber.Id);
                if(item == null)
                {
                    retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                    retorno.Sucesso = false;
                }
               
                item.DataAlteracao = DateTime.Now.ToLocalTime();                
                _context.ContasReceber.Update(receber);
                await _context.SaveChangesAsync();
                retorno.DadosRetorno = true;            
            
            }catch(Exception ex){
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }
            return retorno;
        }

        public async Task<ServiceResponse<ContasReceber>> FindId(int id)
        {
            var retorno = new ServiceResponse<ContasReceber>();
            try{
                ContasReceber item = await _context.ContasReceber.FirstOrDefaultAsync(p=>p.Id == id);
                retorno.DadosRetorno = item;

                if(item == null)
                {
                    retorno.DadosRetorno = null;
                    retorno.Mensagem = "Conta a receber não existe no banco de dados.";
                    retorno.Sucesso = false;
                }
           
            }catch(Exception ex){
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }
           return retorno;
        }

        public async Task<ServiceResponse<IEnumerable<ContasReceber>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ContasReceber>>();
            try{                
                retorno.DadosRetorno = await _context.ContasReceber.ToListAsync();
                if(retorno.DadosRetorno == null){
                    retorno.Mensagem = "Nenhuma conta a receber encontrada.";
                }

            }catch(Exception ex){
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
                ContasReceber item = await _context.ContasReceber.FirstOrDefaultAsync(p=>p.Id == id);
                
               _context.ContasReceber.Remove(item);
                await _context.SaveChangesAsync();

                retorno.DadosRetorno = true;
                retorno.Mensagem = "Conta a receber removida com sucesso.";

            
            }catch(Exception ex){
                retorno.Mensagem = $@"Erro ao remover conta a receber. {ex.Message}";
                retorno.Sucesso = false;
            }
         
            return retorno;
        }

        public async Task<ServiceResponse<Boolean>> Salvar(ContasReceber contasreceber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                _context.ContasReceber.Add(contasreceber);
                await _context.SaveChangesAsync();
                retorno.DadosRetorno = true;
                retorno.Mensagem = "Dados gravados com sucesso.";
            }
            catch (Exception e)
            {                
                retorno.Mensagem = $@"Erro ao gravar conta a receber no banco de dados. {e.Message}";
            }
            return  retorno;
        }
    }
}