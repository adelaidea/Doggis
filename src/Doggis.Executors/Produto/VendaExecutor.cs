using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class VendaExecutor : IExecutor<VendaParameter, VendaResult>
    {
        private readonly IMapper _mapper;
        private readonly IVendaRepository _vendaRepository;
        private readonly IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult> _editarQuantidadeProdutoExecutor;

        public VendaExecutor(IMapper mapper, IVendaRepository vendaRepository,
                                IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult> editarQuantidadeProdutoExecutor)
        {
            _mapper = mapper;
            _vendaRepository = vendaRepository;
            _editarQuantidadeProdutoExecutor = editarQuantidadeProdutoExecutor;
        }

        public async Task<VendaResult> Execute(VendaParameter parameter)
        {
            var venda = new Venda()
            {
                FuncionarioVendaId = parameter.IdFuncionario,
                Itens = _mapper.Map<IEnumerable<ItemVenda>>(parameter.Itens)
            };

            await _vendaRepository.Add(venda);

            foreach (var item in parameter.Itens)
            {
                await _editarQuantidadeProdutoExecutor.Execute(new AtualizarEstoqueProdutoParameter { Codigo = item.CodigoProduto, Quantidade = item.Quantidade, Somar = false });
            }

            return new VendaResult();
        }
    }
}