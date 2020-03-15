using Doggis.ExecutorsAbstraction.Model.Produto;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto
{
    public class ListarProdutoResult : ResultBase
    {
        public ListarProdutoResult()
        {
            Produtos = new List<ProdutoModel>();
        }

        public IEnumerable<ProdutoModel> Produtos { get; set; }
    }
}
