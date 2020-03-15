using Doggis.ExecutorsAbstraction.Model.Produto;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto
{
    public class ObterProdutoResult : ResultBase
    {
        public ProdutoModel Produto { get; set; }
    }
}
