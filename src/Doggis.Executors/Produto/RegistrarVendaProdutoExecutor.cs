using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Executors.Produto
{
    public class RegistrarVendaProdutoExecutor : IExecutor<RegistrarVendaProdutoParameter, RegistrarVendaProdutoResult>
    {
        public async Task<RegistrarVendaProdutoResult> Execute(RegistrarVendaProdutoParameter parameter)
        {
            return new RegistrarVendaProdutoResult();
        }
    }
}
