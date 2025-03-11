using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategorias _repository;
        public CategoriasController(ICategorias repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CategoriaReceitas>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaReceitas>> FindbyId(int id)
        {
            ServiceResponse<CategoriaReceitas> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(CategoriaReceitas Categorias)
        {
            return Ok(await _repository.Salvar(Categorias));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(CategoriaReceitas Categorias)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(Categorias);
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
