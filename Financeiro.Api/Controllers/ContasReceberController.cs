using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasReceberController : ControllerBase
    {
        private readonly IContasReceberRepository _repository;
        public ContasReceberController(IContasReceberRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasReceberDTO>>>> ListarContas()
        {
            var lista = await _repository.ListarContas();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasReceberDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContasReceberDTO contasreceber)
        {
            try
            {
                var itens = new ContasReceber
                {

                };

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasReceber contasreceber)
        {
            var contaReceberAtualizar = await _repository.Atualizar(contasreceber);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }

    }
}
