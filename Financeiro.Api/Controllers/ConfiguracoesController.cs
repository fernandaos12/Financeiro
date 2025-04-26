using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    public class ConfiguracoesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ConfiguracoesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ConfiguracoesDTO>>>> ListarContas()
        {
            var retorno = new ServiceResponse<IEnumerable<ConfiguracoesDTO>>();
            try
            {
                var command = new ListarConfiguracoesQuery();
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
        public async Task<ActionResult<ConfiguracoesDTO>> FindbyId(int id)
        {
            var retorno = new ServiceResponse<ConfiguracoesDTO>();
            try
            {
                var command = new ObterConfiguracoesPorIdQuery(id);
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
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ConfiguracoesDTO config)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new GravarConfiguracoesCommand(config);
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
        public async Task<ActionResult<Boolean>> AtualizarItem(Configuracoes configuracoes)
        {
            var retorno = new ServiceResponse<Boolean>();
            try
            {
                var command = new AtualizarConfiguracoesCommand(configuracoes);
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
                var command = new RemoverConfiguracoesCommand(id);
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