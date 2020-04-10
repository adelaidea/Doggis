using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Fabricante;
using Doggis.ExecutorsAbstraction.Model.Fabricante;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Fabricante
{
    public class ListarFabricanteExecutor : IExecutor<ListarFabricanteResult>
    {
        private readonly IFabricanteRepository _fabricanteRepository;
        private readonly IMapper _mapper;

        public ListarFabricanteExecutor(IMapper mapper, IFabricanteRepository fabricanteRepository)
        {
            _mapper = mapper;
            _fabricanteRepository = fabricanteRepository;
        }

        public async Task<ListarFabricanteResult> Execute()
        {
            var fabricantes = await _fabricanteRepository.GetAll();

            return new ListarFabricanteResult { Fabricantes = _mapper.Map<IEnumerable<FabricanteModel>>(fabricantes) };
        }
    }
}