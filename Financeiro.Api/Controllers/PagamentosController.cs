using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Application.UseCases.Pagamentos.Commands;
using Financeiro.Application.UseCases.Pagamentos.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PagamentosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<PagamentoDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IList<PagamentoDTO>>();
            try
            {
                var command = new ListarPagamentosQuery();
                var lista = (await _mediator.Send(command)).Dados;

                retorno.DadosRetorno = lista;
                retorno.Sucesso = true;

                return Ok(lista);
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PagamentoDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<PagamentoDTO>();
            try
            {
                var command = new ObterPagamentoPorIdQuery(id);
                var item = (await _mediator.Send(command)).Dados;

                retorno.DadosRetorno = item;
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
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(PagamentoDTO pagamentos)
        {
            var retorno = new ServiceResponse<Boolean>();

            try
            {
                var command = new GravarPagamentoCommand(pagamentos);
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
        public async Task<ActionResult<Boolean>> AtualizarItem(PagamentoDTO pagamentos)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new AtualizarPagamentoCommand(pagamentos);
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
        public async Task<ActionResult<bool>> Apagar(int id)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new RemoverPagamentoCommand(id);
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
