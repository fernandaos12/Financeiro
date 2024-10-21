using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IPagamentos _repository;
        public PagamentosController(IPagamentos repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Pagamento>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pagamento>> FindbyId(int id)
        {
            ServiceResponse<Pagamento> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(Pagamento Pagamentos)
        {
            return Ok(await _repository.Salvar(Pagamentos));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(Pagamento Pagamentos)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(Pagamentos);
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
