using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Mvc;

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

        
    }
}