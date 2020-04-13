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
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        public ServicoRepository(DoggisContext dbContext)
            : base(dbContext) { }

        public async Task AgendarServico(AgendaServico agendaServico)
        {
            _dbContext.Add<AgendaServico>(agendaServico);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AgendaServico>> ObterServicosAgendadosDia(DateTime data)
        {
            var retorno = await _dbContext.AgendaServico.Where(x => x.DataRealizacao.Date == data.Date).ToListAsync();

            return retorno;
        }
    }
}