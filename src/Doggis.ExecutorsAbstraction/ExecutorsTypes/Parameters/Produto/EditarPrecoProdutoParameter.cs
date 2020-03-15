namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto
{
    public class EditarPrecoProdutoParameter : ParameterBase
    {
        public long Codigo { get; set; }
        public decimal Preco { get; set; }
    }
}