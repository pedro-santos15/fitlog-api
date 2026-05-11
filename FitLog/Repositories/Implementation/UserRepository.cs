using FitLog.Model;
using FitLog.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace FitLog.Repositories.Implementation
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
