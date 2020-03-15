using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;

namespace Doggis.DataAccess.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DoggisContext _dbContext;

        public ProdutoRepository(DoggisContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
