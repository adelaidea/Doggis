using System;

namespace Doggis.Domain.Entities
{
    public class ItemVenda : EntityBase
    {
        public Guid VendaId { get; set; }
        
        public long CodigoProduto { get; set; }

        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorItem { get; set; }
    }
}
