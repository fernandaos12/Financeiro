using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasReceberController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContasReceberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasReceberDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ContasReceberDTO>>();
            try
            {
                var command = new ListarContasReceberQuery();
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
        public async Task<ActionResult<ContasReceberDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<ContasReceberDTO>();
            try
            {
                var command = new ObterContasReceberPorIdQuery(id);
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
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContasReceberDTO contasreceber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new GravarContasReceberCommand(contasreceber);
                _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados gravados com sucesso.";

            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasReceber contasreceber)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new AtualizarContasReceberCommand(contasreceber);
                await _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados atualizados com sucesso.";
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
                var command = new RemoverContasReceberCommand(id);
                await _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.Mensagem = "Dados removidos com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }
            return Ok(retorno);
        }

    }
}
