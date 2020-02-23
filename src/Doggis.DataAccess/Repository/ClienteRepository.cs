using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;

namespace Doggis.DataAccess.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DoggisContext _dbContext;

        public ClienteRepository(DoggisContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
