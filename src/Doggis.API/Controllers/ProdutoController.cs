using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using Doggis.ExecutorsAbstraction.Model.Produto;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IExecutor<ListarProdutoParameter, ListarProdutoResult> _listarProdutoExecutor;
        private readonly IExecutor<IncluirProdutoParameter, IncluirProdutoResult> _incluirProdutoExecutor;
        private readonly IExecutor<EditarProdutoParameter, EditarProdutoResult> _editarProdutoExecutor;
        private readonly IExecutor<RemoverProdutoParameter, RemoverProdutoResult> _removerProdutoExecutor;
        private readonly IExecutor<EditarPrecoProdutoParameter, EditarPrecoProdutoResult> _editarPrecoProdutoExecutor;
        private readonly IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult> _editarQuantidadeProdutoExecutor;
        private readonly IExecutor<VendaParameter, VendaResult> _vendaExecutor;
        private readonly IExecutor<ObterProdutoParameter, ObterProdutoResult> _obterProdutoExecutor;

        public ProdutoController(IExecutor<ListarProdutoParameter, ListarProdutoResult> listarProdutoExecutor,
                                    IExecutor<IncluirProdutoParameter, IncluirProdutoResult> incluirProdutoExecutor,
                                    IExecutor<EditarProdutoParameter, EditarProdutoResult> editarProdutoExecutor,
                                    IExecutor<RemoverProdutoParameter, RemoverProdutoResult> removerProdutoExecutor,
                                    IExecutor<EditarPrecoProdutoParameter, EditarPrecoProdutoResult> editarPrecoProdutoExecutor,
                                    IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult> editarQuantidadeProdutoExecutor,
                                    IExecutor<VendaParameter, VendaResult> vendaExecutor,
                                    IExecutor<ObterProdutoParameter, ObterProdutoResult> obterProdutoExecutor)
        {
            _listarProdutoExecutor = listarProdutoExecutor;
            _incluirProdutoExecutor = incluirProdutoExecutor;
            _editarProdutoExecutor = editarProdutoExecutor;
            _removerProdutoExecutor = removerProdutoExecutor;
            _editarPrecoProdutoExecutor = editarPrecoProdutoExecutor;
            _editarQuantidadeProdutoExecutor = editarQuantidadeProdutoExecutor;
            _vendaExecutor = vendaExecutor;
            _obterProdutoExecutor = obterProdutoExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var produtos = await _listarProdutoExecutor.Execute(new ListarProdutoParameter());

                return Ok(produtos.Produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> Obter(long id)
        {
            try
            {
                var produto = await _obterProdutoExecutor.Execute(new ObterProdutoParameter { Codigo = id });

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Incluir(IEnumerable<ProdutoModel> produtos)
        {
            try
            {
                await _incluirProdutoExecutor.Execute(new IncluirProdutoParameter { Produtos = produtos });

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody]ProdutoModel produto)
        {
            try
            {
                await _editarProdutoExecutor.Execute(new EditarProdutoParameter { Produto = produto });

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("{id?}")]
        public async Task<IActionResult> Remover(long id)
        {
            try
            {
                await _removerProdutoExecutor.Execute(new RemoverProdutoParameter { Codigo = id });

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPatch]
        public async Task<IActionResult> EditarPreco(EditarPrecoProdutoParameter parameter)
        {
            try
            {
                await _editarPrecoProdutoExecutor.Execute(parameter);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPatch]
        public async Task<IActionResult> EditarQuantidade(AtualizarEstoqueProdutoParameter parameter)
        {
            try
            {
                await _editarQuantidadeProdutoExecutor.Execute(parameter);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPatch]
        public async Task<IActionResult> RegistrarVenda(VendaParameter parameter)
        {
            try
            {
                await _vendaExecutor.Execute(parameter);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}