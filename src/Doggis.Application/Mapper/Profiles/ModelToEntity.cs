using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.ExecutorsAbstraction.Model.Produto;
using Doggis.ExecutorsAbstraction.Model.Servico;
using System;

namespace Doggis.Application.Mapper.Profiles
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<ProdutoModel, Produto>().ForMember(x => x.Codigo, opt => opt.Ignore());
            CreateMap<ItemVendaModel, ItemVenda>();

            CreateMap<AgendaServicoModel, AgendaServico>().ForMember(x => x.DataRealizacao, opt => opt.MapFrom(x => new DateTime(x.DataRealizacao.Year, x.DataRealizacao.Month, x.DataRealizacao.Day, x.Hora, 0, 0)));
        }
    }
}