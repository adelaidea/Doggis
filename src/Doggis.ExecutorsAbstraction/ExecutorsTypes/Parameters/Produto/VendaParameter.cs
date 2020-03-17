using Doggis.ExecutorsAbstraction.Model.Produto;
using System;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto
{
    public class VendaParameter : ParameterBase
    {
        public Guid IdFuncionario { get; set; }

        public IEnumerable<ItemVendaModel> Itens { get; set; }
    }
}
