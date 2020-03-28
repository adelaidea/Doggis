using System;

namespace Doggis.Domain.Entities
{
    public class Servico : EntityBase
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int MinDuracao { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public int PontosRealizavao { get; set; }

    }
}