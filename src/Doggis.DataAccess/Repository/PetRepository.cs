using Doggis.DataAccess.Context;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;

namespace Doggis.DataAccess.Repository
{
    public class PetRepository : BaseRepository<Pet>, IPetRepository
    {
        public PetRepository(DoggisContext dbContext)
            : base(dbContext) { }
    }
}