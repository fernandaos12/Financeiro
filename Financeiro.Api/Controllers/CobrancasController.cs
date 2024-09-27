using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancasController : ControllerBase
    {
           private readonly CobrancaRepository _repository;
        public CobrancaController(CobrancaRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Cobrancas>> ListarContas()
        {
           var retorno = await _repository.Get();

           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Cobranca> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Cobranca cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Cobranca cp)
        { 
            var item = await _repository.FindId(cp.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            _repository.Atualizar(cp);            
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
