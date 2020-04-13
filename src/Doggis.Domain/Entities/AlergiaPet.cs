using System;

namespace Doggis.Domain.Entities
{
    public class AlergiaPet : EntityBase
    {
        public Guid IdPet { get; set; }

        public int IdAlergia { get; set; }

        public virtual Pet Pet { get; set; }

        public virtual Alergia Alergia { get; set; }
    }
}
