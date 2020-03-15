using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class RemoverProdutoExecutor : IExecutor<RemoverProdutoParameter, RemoverProdutoResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public RemoverProdutoExecutor(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<RemoverProdutoResult> Execute(RemoverProdutoParameter parameter)
        {
            await _produtoRepository.Delete(parameter.Codigo);

            return new RemoverProdutoResult();
        }
    }
}