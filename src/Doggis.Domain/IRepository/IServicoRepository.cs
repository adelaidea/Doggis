using Doggis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Domain.IRepository
{
    public interface IServicoRepository : IBaseRepository<Servico>
    {
        Task AgendarServico(AgendaServico agendaServico);

        Task<IEnumerable<AgendaServico>> ObterServicosAgendadosDia(DateTime data);
    }
}