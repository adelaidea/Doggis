using System;

namespace Doggis.ExecutorsAbstraction.Model.Servico
{
    public class AgendaServicoModel
    {
        public Guid ClienteId { get; set; }
        public Guid ServicoId { get; set; }
        public Guid FuncionarioId { get; set; }
        public Guid PetId { get; set; }
        public DateTime DataRealizacao { get; set; }
        public string Horario { get; set; }
        public int Hora
        {
            get
            {
                var hora = Convert.ToInt32(Horario.Split('-')[0].Split(':')[0]);

                return hora;
            }
        }
    }
}