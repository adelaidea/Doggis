using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using Doggis.ExecutorsAbstraction.Model.Produto;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class ObterProdutoExecutor : IExecutor<ObterProdutoParameter, ObterProdutoResult>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ObterProdutoExecutor(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
        }

        public async Task<ObterProdutoResult> Execute(ObterProdutoParameter parameter)
        {
            var produto = await _produtoRepository.Get(parameter.Codigo);

            var produtoModel = _mapper.Map<ProdutoModel>(produto);

            return new ObterProdutoResult
            {
                Produto = produtoModel
            };
        }
    }
}