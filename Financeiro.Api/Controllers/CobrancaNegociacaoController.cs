using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancaNegociacaoController : ControllerBase
    {
        private readonly CobrancaNegociacaoRepository _repository;
        public CobrancaNegociacaoController(CobrancaNegociacaoRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Cobranca_Negociacao>> ListarContas()
        {
           var retorno = await _repository.GetAll();
           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Cobranca_Negociacao> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Cobranca_Negociacao cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Cobranca_Negociacao cp)
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
