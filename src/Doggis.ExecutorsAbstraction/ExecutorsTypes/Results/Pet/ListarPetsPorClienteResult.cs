using Doggis.ExecutorsAbstraction.Model.Pet;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Pet
{
    public class ListarPetsPorClienteResult : ResultBase
    {
        public IEnumerable<PetModel> Pets { get; set; }
    }
}
