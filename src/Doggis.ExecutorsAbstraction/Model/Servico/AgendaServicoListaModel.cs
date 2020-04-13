using System;

namespace Doggis.ExecutorsAbstraction.Model.Servico
{
    public class AgendaServicoListaModel
    {
        public Guid ServicoId { get; set; }

        public string ServicoNome { get; set; }

        public Guid PetId { get; set; }

        public string PetNome { get; set; }

        public Guid FuncionarioId { get; set; }

        public string FuncionarioNome { get; set; }

        public Guid ClienteId { get; set; }

        public string ClienteNome { get; set; }

        public string DataRealizacao { get; set; }

        public bool Cancelado { get; set; }
    }
}