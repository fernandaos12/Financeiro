using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasReceberController : ControllerBase
    {
        private readonly IContasReceber _repository;
        public ContasReceberController(IContasReceber repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasReceber>>>> ListarContas()
        {
            return await _repository.ListarContas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasReceber>> FindbyId(int id)
        {
            ServiceResponse<ContasReceber> contaReceberItem  = await _repository.FindId(id);
            return Ok(contaReceberItem);              
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContasReceber contasreceber)
        {
            return Ok(await _repository.Salvar(contasreceber));                 
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasReceber contasreceber)
        { 
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(contasreceber);
            return Ok(contaReceberAtualizar);   
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            ServiceResponse<Boolean> contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);               
        }

    }
}
