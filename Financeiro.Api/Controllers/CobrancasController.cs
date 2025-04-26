using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Cobrancas.Command;
using Financeiro.Application.UseCases.Cobrancas.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CobrancasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CobrancaDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<CobrancaDTO>>();
            try
            {
                var command = new ListarCobrancasQuery();
                retorno.DadosRetorno = (await _mediator.Send(command)).Dados;
                retorno.Sucesso = true;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<CobrancaDTO>>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<CobrancaDTO>();
            try
            {
                var command = new ObterCobrancaPorIdQuery(id);
                retorno.DadosRetorno = (await _mediator.Send(command)).Dados;
                retorno.Sucesso = true;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<bool>>> Salvar(CobrancaDTO cp)
        {
            var retorno = new ServiceResponse<bool>();
            try
            {
                var command = new GravarCobrancaCommand(cp);
                await _mediator.Send(command);
                retorno.Sucesso = true;
                retorno.Mensagem = "Dados gravados com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }

            return Ok(retorno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> AtualizarItem(CobrancaDTO cp)
        {
            var retorno = new ServiceResponse<bool>();
            try
            {
                var command = new AtualizarCobrancaCommand(cp);
                await _mediator.Send(command);
                retorno.Sucesso = true;
                retorno.Mensagem = "Dados atualizados com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }
            return Ok(retorno);
        }

        [HttpDelete("{id")]
        public async Task<ActionResult<ServiceResponse<bool>>> Apagar(int id)
        {
            var retorno = new ServiceResponse<bool>();
            try
            {
                var command = new RemoverCobrancaCommand(id);
                await _mediator.Send(command);
                retorno.Sucesso = true;
                retorno.Mensagem = "Dados removidos com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
                retorno.Sucesso = false;
            }
            return Ok(retorno);
        }

    }
}
