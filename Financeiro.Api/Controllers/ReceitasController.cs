using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitas _repository;
        public ReceitasController(IReceitas repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Receitas>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Receitas>> FindbyId(int id)
        {
            ServiceResponse<Receitas> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(Receitas Receitas)
        {
            return Ok(await _repository.Salvar(Receitas));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(Receitas Receitas)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(Receitas);
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
