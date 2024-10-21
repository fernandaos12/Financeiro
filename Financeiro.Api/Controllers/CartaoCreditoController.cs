using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly ICartaoCredito _repository;
        public CartaoCreditoController(ICartaoCredito repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CartaoCredito>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartaoCredito>> FindbyId(int id)
        {
            ServiceResponse<CartaoCredito> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(CartaoCredito CartaoCredito)
        {
            return Ok(await _repository.Salvar(CartaoCredito));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(CartaoCredito CartaoCredito)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(CartaoCredito);
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
