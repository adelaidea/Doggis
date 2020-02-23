using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results;
using System.Threading.Tasks;

namespace Doggis.ExecutorsAbstraction.Abstraction
{
    public interface IExecutor<TParameter, TResult> 
        where TParameter : ParameterBase 
        where TResult : ResultBase
    {
        Task<TResult> Execute(TParameter parameter);
    }
}
