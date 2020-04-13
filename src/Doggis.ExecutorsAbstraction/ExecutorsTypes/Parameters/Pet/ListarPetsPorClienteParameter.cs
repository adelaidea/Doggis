using System;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Pet
{
    public class ListarPetsPorClienteParameter : ParameterBase
    {
        public Guid ClienteId { get; set; }
    }
}
