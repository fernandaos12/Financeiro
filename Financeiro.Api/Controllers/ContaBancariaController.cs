using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaBancariaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContaBancariaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContaBancariaDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ContaBancariaDTO>>();
            try
            {
                var command = new ListarContasBancariasQuery();
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
        public async Task<ActionResult<ContaBancariaDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<ContaBancariaDTO>();
            try
            {
                var command = new ObterContaBancariaPorIdQuery(id);
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
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContaBancariaDTO contaBancaria)
        {

            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new GravarContaBancariaCommand(contaBancaria);
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

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContaBancaria contaBancaria)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new AtualizarContaBancariaCommand(contaBancaria);
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

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new RemoverContaBancariaCommand(id);
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
