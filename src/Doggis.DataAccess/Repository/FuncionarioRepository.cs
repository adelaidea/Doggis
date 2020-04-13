using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doggis.DataAccess.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(DoggisContext dbContext)
            : base(dbContext) { }

        public async Task<IEnumerable<DisponibilidadeFuncionario>> GetDisponibilidade(Guid funcionarioId)
        {
            var result = await _dbContext.DisponibilidadeFuncionario.Where(x => x.FuncionarioId == funcionarioId).ToListAsync();

            return result;
        }
    }
}