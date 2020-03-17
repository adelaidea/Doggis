namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto
{
    public class AtualizarEstoqueProdutoParameter : ParameterBase
    {
        public long Codigo { get; set; }

        public int Quantidade { get; set; }

        public bool? Somar { get; set; }
    }
}
