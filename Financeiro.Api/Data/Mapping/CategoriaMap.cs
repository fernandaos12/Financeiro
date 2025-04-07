using AutoMapper;
using Financeiro.Api.Models;
using Financeiro.Api.Models.DTO;

namespace Financeiro.Api.Data.Mapping
{
    public class CategoriaMap : Profile
    {
        public CategoriaMap()
        {
            CreateMap<Categorias, CategoriaDTO>().ReverseMap();
        }
    }
}
