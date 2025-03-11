using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly IContasPagar _repository;
        public ContasPagarController(IContasPagar repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasPagar>>>> ListarContas()
        {
            return await _repository.ListarContas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasPagar>> FindbyId(int id)
        {
            ServiceResponse<ContasPagar> contaPagarItem = await _repository.FindId(id);
            return Ok(contaPagarItem);
        }

        [HttpPost(), DisableRequestSizeLimit]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContasPagar contaspagar)
        {
            return Ok(await _repository.Salvar(contaspagar));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasPagar contaspagar)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(contaspagar);
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