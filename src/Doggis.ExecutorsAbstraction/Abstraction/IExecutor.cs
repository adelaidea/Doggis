using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results;
using System.Threading.Tasks;

namespace Doggis.ExecutorsAbstraction.Abstraction
{
    public interface IExecutor<TResult>
         where TResult : ResultBase
    {
        Task<TResult> Execute();
    }
}
