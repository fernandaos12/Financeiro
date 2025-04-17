using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;


namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly IContasPagarRepository _repo;

        public ContasPagarController(IContasPagarRepository repo)
        {
            _repo = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasPagarDTO>>>> ListarContas()
        {
            var lista = await _repo.Listar();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasPagarDTO>> FindbyId(int id)
        {
            var item = await _repo.BuscarPorId(id);
            return Ok(item);
        }

        [HttpPost(), DisableRequestSizeLimit]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] ContasPagarDTO contaspagar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _repo.Cadastrar(contaspagar);
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasPagarDTO contaspagar)
        {
            var contaReceberAtualizar = await _repo.Atualizar(contaspagar);
            return Ok(true);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var contaReceberRemover = await _repo.Excluir(id);
            return Ok(true);
        }
    }
}