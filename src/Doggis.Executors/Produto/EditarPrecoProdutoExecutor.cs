using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class EditarPrecoProdutoExecutor : IExecutor<EditarPrecoProdutoParameter, EditarPrecoProdutoResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public EditarPrecoProdutoExecutor(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<EditarPrecoProdutoResult> Execute(EditarPrecoProdutoParameter parameter)
        {
            var produto = await _produtoRepository.Get(parameter.Codigo);

            produto.Preco = parameter.Preco;

            await _produtoRepository.Update(produto);

            return new EditarPrecoProdutoResult();
        }
    }
}