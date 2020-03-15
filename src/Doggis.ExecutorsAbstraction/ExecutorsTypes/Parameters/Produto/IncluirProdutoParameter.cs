using Doggis.ExecutorsAbstraction.Model.Produto;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto
{
    public class IncluirProdutoParameter : ParameterBase
    {
        public IEnumerable<ProdutoModel> Produtos { get; set; }
    }
}
