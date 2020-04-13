using System;

namespace Doggis.ExecutorsAbstraction.Model.Pet
{
    public class PetModel
    {
        public Guid Id { get; protected set; }

        public string Raca { get; set; }

        public string Nome { get; set; }

        public string Porte { get; set; }

        public string Observacoes { get; set; }

        public bool PermiteDivulgacao { get; set; }

        public Guid ClienteId { get; set; }

        public int TipoPetId { get; set; }
    }
}
