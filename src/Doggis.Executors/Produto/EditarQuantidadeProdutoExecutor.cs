using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class EditarQuantidadeProdutoExecutor : IExecutor<EditarQuantidadeProdutoParameter, EditarQuantidadeProdutoResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public EditarQuantidadeProdutoExecutor(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<EditarQuantidadeProdutoResult> Execute(EditarQuantidadeProdutoParameter parameter)
        {
            var produto = await _produtoRepository.Get(parameter.Codigo);

            produto.Quantidade = parameter.Quantidade;

            await _produtoRepository.Update(produto);

            return new EditarQuantidadeProdutoResult();
        }
    }
}