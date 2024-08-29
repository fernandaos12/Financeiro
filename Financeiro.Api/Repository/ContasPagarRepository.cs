using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;

namespace Financeiro.Api.Repository
{
    public class ContasPagarRepository : IContasPagar
    {
        public void Atualizar(ContasPagar cp)
        {
            throw new NotImplementedException();
        }

        public Task<ContasPagar> FindId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ContasPagar> ListarContas()
        {
            throw new NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(ContasPagar cp)
        {
            throw new NotImplementedException();
        }
    }
}