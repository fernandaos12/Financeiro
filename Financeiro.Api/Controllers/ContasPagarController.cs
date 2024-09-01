using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/contaspagar")]
    public class ContasPagarController : ControllerBase
    {
        public List<ContasPagar> Get()
        {
            return new List<ContasPagar>();
        }
    }
}