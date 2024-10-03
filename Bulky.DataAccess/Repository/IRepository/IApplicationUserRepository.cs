using Bulky.Models;

namespace bulky.DataAccess.Repository.IRepository;

public interface IApplicationUserRepository : IRepository<ApplicationUser>
{
public void Update(ApplicationUser applicationUser);
    
}