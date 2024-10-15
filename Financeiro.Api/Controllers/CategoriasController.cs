using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly CategoriasRepository _repository;
        public CategoriasController(CategoriasRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Categorias>> ListarContas()
        {
            return await _repository.Listar();          
        }

        [HttpGet("{id}")]
        public async Task<Categorias> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Categorias categoria)
        {
            await _repository.Salvar(categoria);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Categorias categoria)
        { 
            var item = await _repository.FindId(categoria.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }            
            await _repository.Atualizar(categoria);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Categoria não encontrada.");
            }
            await _repository.Remover(id);
            return true;  
        }

    }
}
