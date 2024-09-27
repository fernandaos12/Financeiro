using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    public class ConfiguracoesController : ControllerBase 
    {
        private readonly ConfiguracoesRepository _repository;
        public ConfiguracoesController(ConfiguracoesRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Configuracoes>> ListarContas()
        {
           var retorno = await _repository.GetAll();
           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Configuracoes> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Configuracoes cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Configuracoes cp)
        { 
            var item = await _repository.FindId(cp.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            await _repository.AtualizarItem(cp);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Item não encontrado.");
            }
            await _repository.Remover(id);
            return true;  
        }

    }
}