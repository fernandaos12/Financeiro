using Financeiro.Api.Repository.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        private readonly IContasPagarRepository _repo;

        public ContaPagarController(IContasPagarRepository repo)
        {
            _repo = repo;
        }
        // GET: api/<ContaPagarController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContasPagarDTO>>> ListarContas()
        {
            var lista = await _repo.ListarContas();
            return Ok(lista);
        }

        // GET api/<ContaPagarController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ContasPagarDTO>>> FindbyId(int id)
        {
            var item = await _repo.FindId(id);
            return Ok(item);
        }

        // POST api/<ContaPagarController>
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] ContasPagarDTO value)
        {
            try
            {
                var itens = new ContasPagar
                {
                    Descricao = value.Descricao,
                    Valor = value.Valor,
                    Data_Vencimento = value.Data_Vencimento,
                    DataAlteracao = DateTime.Now,
                    Status = Domain.Enums.Status_Default.Ativo,
                    ValorPago = value.ValorPago,
                    ValorParcela = value.ValorParcela,
                    Periodicidade = value.Periodicidade,
                    Repeticao = (Domain.Enums.TipoRepeticao)value.Repeticao,
                    Anexos = value.Anexos,
                    CaminhoAnexos = value.CaminhoAnexos,
                    Observacao = value.Observacao,
                    NumeroParcelas = value.NumeroParcelas,
                    Categoria = (Domain.Enums.TipoCategoria)value.Categoria
                };
                await _repo.Salvar(itens);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            return Ok(true);
        }

        // PUT api/<ContaPagarController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Atualizar(int id, [FromBody] ContasPagarDTO value)
        {
            var itens = new ContasPagar
            {
                Id = id,
                Descricao = value.Descricao,
                Data_Vencimento = value.Data_Vencimento,
                DataAlteracao = DateTime.Now,
                Valor = value.Valor,
                Status = Domain.Enums.Status_Default.Ativo,
                ValorPago = value.ValorPago,
                ValorParcela = value.ValorParcela,
                Periodicidade = value.Periodicidade,
                Repeticao = (Domain.Enums.TipoRepeticao)value.Repeticao,
                Anexos = value.Anexos,
                CaminhoAnexos = value.CaminhoAnexos,
                Observacao = value.Observacao,
                NumeroParcelas = value.NumeroParcelas,
                Categoria = (Domain.Enums.TipoCategoria)value.Categoria
            };
            await _repo.Atualizar(itens);
            return Ok(true);
        }

        // DELETE api/<ContaPagarController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Remover(int id)
        {
            var item = await _repo.Remover(id);
            return Ok(item);
        }
    }
}
