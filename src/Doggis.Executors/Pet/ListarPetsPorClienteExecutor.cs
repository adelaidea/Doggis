using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Pet;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Pet;
using Doggis.ExecutorsAbstraction.Model.Pet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Pet
{
    public class ListarPetsPorClienteExecutor : IExecutor<ListarPetsPorClienteParameter, ListarPetsPorClienteResult>
    {
        private readonly IMapper _mapper;
        private readonly IPetRepository _petRepository;

        public ListarPetsPorClienteExecutor(IMapper mapper, IPetRepository petRepository)
        {
            _mapper = mapper;
            _petRepository = petRepository;
        }

        public async Task<ListarPetsPorClienteResult> Execute(ListarPetsPorClienteParameter parameter)
        {
            var pets = await _petRepository.Find(x => x.ClienteId == parameter.ClienteId);

            return new ListarPetsPorClienteResult { Pets = _mapper.Map<IEnumerable<PetModel>>(pets) };
        }
    }
}