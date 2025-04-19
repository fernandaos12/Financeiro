using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancaNegociacaoController : ControllerBase
    {
        private readonly ICobrancaNegociacaoRepository _repository;
        public CobrancaNegociacaoController(ICobrancaNegociacaoRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CobrancaNegociacaoDTO>>>> ListarContas()
        {
            await _repository.Listar();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CobrancaNegociacaoDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(CobrancaNegociacaoDTO negociacao)
        {
            var itens = new Cobranca_Negociacao
            {

            };
            await _repository.Salvar(itens);
            return Ok();
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(CobrancaNegociacaoDTO negociacao)
        {
            var itens = new Cobranca_Negociacao
            {

            };
            await _repository.Atualizar(itens);
            return Ok();
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            bool contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }
    }
}
