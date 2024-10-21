using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancaNegociacaoController : ControllerBase
    {
        private readonly ICobrancaNegociacao _repository;
        public CobrancaNegociacaoController(ICobrancaNegociacao repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Cobranca_Negociacao>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cobranca_Negociacao>> FindbyId(int id)
        {
            ServiceResponse<Cobranca_Negociacao> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(Cobranca_Negociacao Cobranca_Negociacao)
        {
            return Ok(await _repository.Salvar(Cobranca_Negociacao));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(Cobranca_Negociacao Cobranca_Negociacao)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(Cobranca_Negociacao);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            ServiceResponse<Boolean> contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }
    }
}
