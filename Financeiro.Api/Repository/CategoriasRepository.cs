using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;

namespace Financeiro.Api.Repository
{
    public class CategoriasRepository : ICategorias
    {
        public void Atualizar(Categorias categoria)
        {
            throw new NotImplementedException();
        }

        public Task<Categorias> FindId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categorias> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Remover(int id)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(Categorias categoria)
        {
            throw new NotImplementedException();
        }
    }
}