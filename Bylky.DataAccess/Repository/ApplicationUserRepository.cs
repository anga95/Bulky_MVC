using Bulky.DataAccess.Data;
using Bulky.Models;
using Bylky.DataAccess.Repository.IRepository;

namespace Bylky.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
