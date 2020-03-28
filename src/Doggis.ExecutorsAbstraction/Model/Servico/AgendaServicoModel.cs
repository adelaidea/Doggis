using System;

namespace Doggis.ExecutorsAbstraction.Model.Servico
{
    public class AgendaServicoModel
    {
        public Guid ClienteId { get; set; }
        public Guid ServicoId { get; set; }
        public Guid FuncionaarioId { get; set; }
        public Guid PetId { get; set; }
        public DateTime DataRealizacao { get; set; }
    }
}