using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriasRepository _repository;
        public CategoriasController(ICategoriasRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CategoriaDTO>>>> ListarContas()
        {
            var lista = await _repository.Listar();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] CategoriaDTO categorias)
        {
            var itens = new Categorias
            {
                Descricao = categorias.Descricao,
                Status = categorias.Status,
                DataAlteracao = DateTime.Now,
                TipoCategoria = (TipoCategoria)categorias.tipoCategoria,
                CorGrafico = categorias.CorGrafico
            };
            await _repository.Salvar(itens);
            return Ok();
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(CategoriaDTO categorias)
        {
            var itens = new Categorias
            {
                Descricao = categorias.Descricao,
                Status = categorias.Status,
                DataAlteracao = DateTime.Now,
                TipoCategoria = (TipoCategoria)categorias.tipoCategoria,
                CorGrafico = categorias.CorGrafico
            };
            await _repository.Atualizar(itens);
            return Ok();
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var item = await _repository.FindId(id);
            if (item == null)
                return BadRequest("Item não encontrado");

            await _repository.Remover(id);
            return Ok();
        }
    }
}
