using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.ExecutorsAbstraction.Model.Produto;
using Doggis.ExecutorsAbstraction.Model.Servico;

namespace Doggis.Application.Mapper.Profiles
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<ProdutoModel, Produto>();
            CreateMap<ItemVendaModel, ItemVenda>();
            CreateMap<AgendaServicoModel, AgendaServico>();
        }
    }
}