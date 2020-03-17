using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class AtualizarEstoqueProdutoExecutor : IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public AtualizarEstoqueProdutoExecutor(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<AtualizarEstoqueProdutoResult> Execute(AtualizarEstoqueProdutoParameter parameter)
        {
            var produto = await _produtoRepository.Get(parameter.Codigo);
            
            produto.Quantidade = GetNovaQuantidade(produto.Quantidade, parameter.Quantidade, parameter.Somar);

            await _produtoRepository.Update(produto);

            return new AtualizarEstoqueProdutoResult();
        }

        private int GetNovaQuantidade(int quantidadeAtual, int quantidadeAtualizar, bool? somar) 
        {
            int result;

            if (!somar.HasValue)
                result = quantidadeAtualizar;
            else if (somar.HasValue && somar.Value)
                result = quantidadeAtual + quantidadeAtualizar;
            else
                result = quantidadeAtual - quantidadeAtualizar;

            return result;
        }
    }
}