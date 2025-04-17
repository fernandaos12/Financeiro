using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        private readonly IMapper _map;
        private readonly IApplicationContasPagar _repo;

        public ContaPagarController(IContasPagarRepository repo)
        {

        }
        // GET: api/<ContaPagarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContaPagarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContaPagarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContaPagarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContaPagarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
