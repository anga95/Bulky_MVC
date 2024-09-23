using Bulky.DataAccess.Data;
using Bulky.Models;
using Bylky.DataAccess.Repository.IRepository;

namespace Bylky.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Update(obj);
        }
    }
}
