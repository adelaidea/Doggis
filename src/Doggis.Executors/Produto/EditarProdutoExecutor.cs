using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class EditarProdutoExecutor : IExecutor<EditarProdutoParameter, EditarProdutoResult>
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;

        public EditarProdutoExecutor(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
        }

        public async Task<EditarProdutoResult> Execute(EditarProdutoParameter parameter)
        {
            var produto = _mapper.Map<Domain.Entities.Produto>(parameter.Produto);

            await _produtoRepository.Update(produto);

            return new EditarProdutoResult();
        }
    }
}