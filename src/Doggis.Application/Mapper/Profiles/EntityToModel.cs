using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.ExecutorsAbstraction.Model.Produto;

namespace Doggis.Application.Mapper.Profiles
{
    public class EntityToModel : Profile
    {
        public EntityToModel()
        {
            CreateMap<Produto, ProdutoModel>();
        }
    }
}
