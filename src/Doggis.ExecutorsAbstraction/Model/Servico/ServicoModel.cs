using System;

namespace Doggis.ExecutorsAbstraction.Model.Servico
{
    public class ServicoModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int MinDuracao { get; set; }

        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public int PontosRealizacao { get; set; }
    }
}
