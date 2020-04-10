using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;

namespace Doggis.DataAccess.Repository
{
    public class FabricanteRepository : BaseRepository<Fabricante>, IFabricanteRepository
    {
        private readonly DoggisContext _dbContext;

        public FabricanteRepository(DoggisContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
