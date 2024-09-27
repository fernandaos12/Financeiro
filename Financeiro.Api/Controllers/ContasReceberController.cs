using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasReceberController : ControllerBase
    {
        private readonly ContasReceberRepository _repository;
        public ContasReceberController(ContasReceberRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<ContasReceber>> ListarContas()
        {
           var retorno = await _repository.ListarContas();

           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<ContasReceber> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(ContasReceber cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(ContasReceber cp)
        { 
            var item = await _repository.FindId(cp.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            await _repository.Atualizar(cp);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a receber não encontrado.");
            }

            await _repository.Remover(id);
            return true;  
        }

    }
}
