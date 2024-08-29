using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;

namespace Financeiro.Api.Repository
{
    public class ContasReceberRepository : IContasReceber
    {
        public void Atualizar(ContasReceber cr)
        {
            throw new NotImplementedException();
        }

        public Task<ContasReceber> FindId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ContasReceber> ListarContas()
        {
            throw new NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(ContasReceber cr)
        {
            throw new NotImplementedException();
        }
    }
}