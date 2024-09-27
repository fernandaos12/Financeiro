using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly ReceitasRepository _repository;
        public ReceitasController(ReceitasRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Receitas>> ListarContas()
        {
           var retorno = await _repository.GetAll();

           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Receitas> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Receitas receitas)
        {
            await _repository.Salvar(receitas);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Receitas receita)
        { 
            var item = await _repository.FindId(receita.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar. Item não encontrado.");
            }
            
           await _repository.AtualizarItem(receita);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Item receita não encontrado.");
            }

            await _repository.Remover(id);
            return true;  
        }

    }
}
