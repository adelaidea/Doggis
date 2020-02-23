using System;

namespace Doggis.Domain.Entities
{
    public class AlergiaPet : EntityBase
    {
        public Guid IdPet { get; set; }

        public int IdAlergia { get; set; }

        public Pet Pet { get; set; }

        public Alergia Alergia { get; set; }
    }
}
