using System;

namespace Doggis.Domain.Entities
{
    public class AgendaServico
    {
        public Guid ServicoId { get; set; }

        public Guid ClienteId { get; set; }

        public Guid PetId { get; set; }

        public Guid FuncionarioId { get; set; }

        public string CodigoPromocao { get; set; }

        public DateTime DataRealizacao { get; set; }

        public decimal ValorPago { get; set; }

        public int Pontos { get; set; }

        public bool Cancelado { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Servico Servico { get; set; }

        public virtual Pet Pet { get; set; }

        public virtual Funcionario Funcionario { get; set; }
    }
}