using Financeiro.Api.Repository.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.ContasPagar.Queries;
using Financeiro.Application.UseCases.ContasPagar.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContasPagarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasPagarDTO>>>> ListarContas()
        {
            var query = new ListarContaPagarQuery();
            var lista = await _mediator.Send(query);
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasPagarDTO>> FindbyId(int id)
        {
            var command = new ObterContaPorIdQuery(id);
            var item = await _mediator.Send(command);
            return Ok(item);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] ContasPagarDTO contaspagar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var command = new RegistrarContasPagarCommand(contaspagar);
            await _mediator.Send(command);
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasPagarDTO contaspagar)
        {
            var command = new AtualizarContaPagarCommand(contaspagar);
            var contaReceberAtualizar = await _mediator.Send(command);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var command = new RemoverContaPagarCommand(id);
            var contaReceberRemover = await _mediator.Send(command);
            return Ok(contaReceberRemover);
        }
    }
}