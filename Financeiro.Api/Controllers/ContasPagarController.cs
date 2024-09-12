using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Financeiro.Api.Controllers
{
    [ApiController]
    public class ContasPagarController //: BaseController
    {
        private readonly ContasPagarRepository _repository;
        public ContasPagarController(ContasPagarRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        [Route("api/contaspagar/listarcontas")]
        public async Task<IEnumerable<ContasPagar>> ListarContas()
        {
           var retorno = await _repository.ListarContas();

           return retorno;
        }

        [HttpGet("{id}")]
        [Route("api/contaspagar/listarcontas/FindById")]
        public async Task<ContasPagar> ObterporId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        [Route("api/contaspagar/listarcontas/Salvar")]
        public async Task<bool> Salvar(ContasPagar cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut()]
        [Route("api/contaspagar/listarcontas/Atualizar")]
        public async void AtualizarItem(ContasPagar cp)
        { 
            var item = await _repository.FindId(cp.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            _repository.Atualizar(cp);            
        }

        [HttpDelete("{id}")]
        [Route("api/contaspagar/listarcontas/Remover")]
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