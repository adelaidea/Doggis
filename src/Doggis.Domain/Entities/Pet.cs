using System;
using System.Collections.Generic;

namespace Doggis.Domain.Entities
{
    public class Pet : EntityBase
    {
        public Guid Id { get; protected set; }

        public int RacaId { get; set; }

        public string Nome { get; set; }

        public string Porte { get; set; }

        public string Observacoes { get; set; }

        public bool PermiteDivulgacao { get; set; }

        public Guid ClienteId { get; set; }

        public virtual Raca Raca { get; set; }

        public virtual IEnumerable<AlergiaPet> Alergias { get; set; }
    }
}
