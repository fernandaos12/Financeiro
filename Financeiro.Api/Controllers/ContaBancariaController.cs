using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaBancariaController : ControllerBase
    {
           private readonly ContaBancariaRepository _repository;
        public ContaBancariaController(ContaBancariaRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<ContaBancaria>> ListarContas()
        {
           var retorno = await _repository.GetAll();
           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<ContaBancaria> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta Bancária não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(ContaBancaria cb)
        {
            await _repository.Salvar(cb);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(ContaBancaria cb)
        { 
            var item = await _repository.FindId(cb.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            await _repository.AtualizarItem(cb);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }

            await _repository.Remover(id);
            return true;  
        }

    }
}
