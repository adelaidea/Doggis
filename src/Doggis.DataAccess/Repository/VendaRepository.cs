using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;

namespace Doggis.DataAccess.Repository
{
    public class VendaRepository : BaseRepository<Venda>, IVendaRepository
    {
        private readonly DoggisContext _dbContext;

        public VendaRepository(DoggisContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
