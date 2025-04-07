using AutoMapper;
using Financeiro.Api.Models;
using Financeiro.Api.Models.DTO;

namespace Financeiro.Api.Data.Mapping
{
    public class PagamentoMap : Profile
    {
        public PagamentoMap()
        {
            CreateMap<Pagamento, PagamentoDTO>().ReverseMap();
        }
    }
}
