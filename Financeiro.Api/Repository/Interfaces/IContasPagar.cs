using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financeiro.Api.Repository.Interfaces
{
    public interface IContasPagar
    {
        IQueryable<ContasPagar> ListarContas();
        Task<ContasPagar> FindId(int id);
        Boolean Salvar(ContasPagar cp);
        void Atualizar(ContasPagar cp);
        Boolean Remover(int id);
    }
}