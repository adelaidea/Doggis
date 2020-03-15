namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto
{
    public class RegistrarVendaProdutoParameter : ParameterBase
    {
        public long Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}