using System;

namespace Doggis.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto()
        {
            Codigo = Codigo.GetNextRadom();
        }

        public long Codigo { get; set; }

        public string Nome { get; set; }

        public string Especificacoes { get; set; }

        public decimal Preco { get; set; }

        public bool ParaVenda { get; set; }

        public int Quantidade { get; set; }
    }

    public static class HelperRadom
    {
        public static long GetNextRadom(this long value)
        {
            Random rdn = new Random();

            long numeroaleatorio = rdn.Next(1, 1000);

            return numeroaleatorio;
        }
    }
}
