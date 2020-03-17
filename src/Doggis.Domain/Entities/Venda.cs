using System;
using System.Collections.Generic;

namespace Doggis.Domain.Entities
{
    public class Venda : EntityBase
    {
        public Venda()
        {
            Id = Guid.NewGuid();
            DataVenda = DateTime.Now;
        }

        public Guid Id { get; private set; }
        
        public DateTime DataVenda { get; private set; }

        public Guid FuncionarioVendaId { get; set; }

        public virtual Funcionario FuncionarioVenda { get; set; }

        public IEnumerable<ItemVenda> Itens { get; set; }
    }
}