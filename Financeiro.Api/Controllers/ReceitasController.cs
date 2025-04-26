using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReceitasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ReceitasDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ReceitasDTO>>();

            try
            {
                var command = new ListarReceitasQuery();
                _mediator.Send(command);

                retorno.Sucesso = true;
                retorno.DadosRetorno = (await _mediator.Send(command)).Dados;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReceitasDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<ReceitasDTO>();
            try
            {
                var command = new ObterReceitaPorIdQuery(id);
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
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ReceitasDTO receitas)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new GravarReceitaCommand(receitas);
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
        public async Task<ActionResult<Boolean>> AtualizarItem(Receitas Receitas)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new AtualizarReceitaCommand(Receitas);
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
                var command = new RemoverReceitaCommand(id);
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
