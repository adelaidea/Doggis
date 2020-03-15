using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class IncluirProdutoExecutor : IExecutor<IncluirProdutoParameter, IncluirProdutoResult>
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;

        public IncluirProdutoExecutor(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
        }

        public async Task<IncluirProdutoResult> Execute(IncluirProdutoParameter parameter)
        {
            var produtos = _mapper.Map<IEnumerable<Domain.Entities.Produto>>(parameter.Produtos);
            
            await _produtoRepository.AddRange(produtos);

            return new IncluirProdutoResult();
        }
    }
}