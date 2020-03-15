using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using Doggis.ExecutorsAbstraction.Model.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class ListarProdutoExecutor : IExecutor<ListarProdutoParameter, ListarProdutoResult>
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;

        public ListarProdutoExecutor(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ListarProdutoResult> Execute(ListarProdutoParameter parameter)
        {
            var produtos = await _produtoRepository.GetAll();

            var result = new ListarProdutoResult();
            result.Produtos = _mapper.Map<IEnumerable<ProdutoModel>>(produtos);

            return result;
        }
    }
}