using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.ExecutorsAbstraction.Model.Cliente;
using Doggis.ExecutorsAbstraction.Model.Fabricante;
using Doggis.ExecutorsAbstraction.Model.Funcionario;
using Doggis.ExecutorsAbstraction.Model.Pet;
using Doggis.ExecutorsAbstraction.Model.Produto;
using Doggis.ExecutorsAbstraction.Model.Servico;

namespace Doggis.Application.Mapper.Profiles
{
    public class EntityToModel : Profile
    {
        public EntityToModel()
        {
            CreateMap<Produto, ProdutoModel>();

            CreateMap<AgendaServico, AgendaServicoListaModel>()
                        .ForMember(dest => dest.ClienteNome, opt => opt.MapFrom(x => x.Cliente.Nome))
                        .ForMember(dest => dest.FuncionarioNome, opt => opt.MapFrom(x => x.Funcionario.Nome))
                        .ForMember(dest => dest.PetNome, opt => opt.MapFrom(x => x.Pet.Nome))
                        .ForMember(dest => dest.ServicoNome, opt => opt.MapFrom(x => x.Servico.Nome))
                        .ForMember(dest => dest.DataRealizacao, opt => opt.MapFrom(x => x.DataRealizacao.ToShortDateString()));

            CreateMap<Fabricante, FabricanteModel>();

            CreateMap<Cliente, ClienteModel>();

            CreateMap<Pet, PetModel>()
                        .ForMember(dest => dest.Raca, opt => opt.MapFrom(x => x.Raca.Nome))
                        .ForMember(dest => dest.TipoPetId, opt => opt.MapFrom(x => x.Raca.TipoPetId));

            CreateMap<Fabricante, FabricanteModel>();

            CreateMap<Servico, ServicoModel>();

            CreateMap<Funcionario, FuncionarioModel>();
        }
    }
}