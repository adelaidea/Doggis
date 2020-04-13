using Doggis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Domain.IRepository
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        Task<IEnumerable<DisponibilidadeFuncionario>> GetDisponibilidade(Guid funcionarioId);
    }
}
