using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.ContasPagar.Commands;
using Financeiro.Application.UseCases.ContasPagar.Queries;
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
            var retorno = new ServiceResponse<IList<ContasPagarDTO>>();
            var listaContas = new List<ContasPagarDTO>();

            try
            {
                var query = new ListarContaPagarQuery();
                var lista = (await _mediator.Send(query)).Dados;
                if (lista != null)
                {
                    listaContas.AddRange(lista);

                    retorno.Sucesso = true;
                    retorno.DadosRetorno = listaContas;
                }
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }
            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasPagarDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<ContasPagarDTO>();

            try
            {
                var command = new ObterContaPorIdQuery(id);
                var item = (await _mediator.Send(command)).Dados;

                if (item != null)
                {
                    retorno.DadosRetorno = item;
                    retorno.Sucesso = true;
                }
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] ContasPagarDTO contaspagar)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var command = new RegistrarContasPagarCommand(contaspagar);
                await _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados gravados com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasPagarDTO contaspagar)
        {
            var retorno = new ServiceResponse<ContasPagarDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var command = new AtualizarContaPagarCommand(contaspagar);
                await _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados atualizados com sucesso.";
                retorno.DadosRetorno = contaspagar;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }


        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new RemoverContaPagarCommand(id);
                await _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados removidos com sucesso.";

            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = "Falha ao excluir conta: " + ex.Message;
            }
            return Ok(retorno);
        }
    }
}