using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.ExecutorsAbstraction.Model.Produto;

namespace Doggis.Application.Mapper.Profiles
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<ProdutoModel, Produto>();
            CreateMap<ItemVendaModel, ItemVenda>();
        }
    }
}
