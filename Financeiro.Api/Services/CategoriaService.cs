using AutoMapper;
using Financeiro.Api.Models;
using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository;
using Financeiro.Api.Services.Interfaces;

namespace Financeiro.Api.Services
{
    public class CategoriaService : ICategoriaDTO
    {
        private readonly CategoriasRepository _repo;
        private readonly Mapper _map;

        public CategoriaService(CategoriasRepository repo, Mapper map)
        {
            _map = map;
            _repo = repo;
        }

        public async Task<CategoriaDTO> Atualizar(CategoriaDTO categoria)
        {
            var obj = _map.Map<Categorias>(categoria);
            await _repo.Atualizar(obj);
            return categoria;
        }

        public async Task<CategoriaDTO> BuscarPorId(int id)
        {
            var item = await _repo.FindId(id) ?? throw new ArgumentException("Categoria não encontrada");
            return _map.Map<CategoriaDTO>(item);
        }

        public async Task<CategoriaDTO> Cadastrar(CategoriaDTO categoria)
        {
            var obj = _map.Map<Categorias>(categoria);
            await _repo.Salvar(obj);
            return categoria;
        }

        public async Task<bool> Excluir(int id)
        {
            var item = await _repo.FindId(id) ?? throw new ArgumentException("Categoria não encontrada");
            _map.Map<CategoriaDTO>(item);
            await _repo.Remover(id);
            return true;
        }

        public async Task<List<CategoriaDTO>> Listar()
        {
            var obj = await _repo.Listar();
            return _map.Map<List<CategoriaDTO>>(obj);
        }
    }
}
