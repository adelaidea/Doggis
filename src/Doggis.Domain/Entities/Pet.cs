using System;
using System.Collections.Generic;

namespace Doggis.Domain.Entities
{
    public class Pet : EntityBase
    {
        public Pet()
        { }

        public Guid Id { get; protected set; }

        public int IdTipoPet { get; set; }

        public int IdRaca { get; set; }

        public string Nome { get; set; }

        public string Porte { get; set; }

        public string Observacoes { get; set; }

        public bool PermiteDivulgacao { get; set; }

        public Guid IdCliente { get; set; }

        public TipoPet TipoPet { get; set; }

        public Raca Raca { get; set; }

        public IEnumerable<AlergiaPet> Alergias { get; set; }
    }
}
