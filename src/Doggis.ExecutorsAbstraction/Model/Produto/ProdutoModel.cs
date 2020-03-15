namespace Doggis.ExecutorsAbstraction.Model.Produto
{
    public class ProdutoModel
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public string Especificacoes { get; set; }
        public decimal Preco { get; set; }
        public bool ParaVenda { get; set; }
        public int Quantidade { get; set; }
    }
}
