using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly PagamentosRepository _repository;
        public PagamentosController(PagamentosRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Pagamento>> ListarContas()
        {
           var retorno = await _repository.GetAll();
           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Pagamento> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Pagamento pg)
        {
            await _repository.Salvar(pg);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Pagamento pg)
        { 
            var item = await _repository.FindId(pg.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }            
            await _repository.AtualizarItem(pg);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Pagamento não encontrado.");
            }
            await _repository.Remover(id);
            return true;  
        }

    }
}
