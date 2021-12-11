using Demo._PRESET_.DbContexts;
using Demo.Models.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class UserService : IUserService
    {
        private readonly DemoDbContext _dbContext;

        public UserService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IUser> GetUserById(long id)
        {
            return await _dbContext.FindAsync<User>(id);
        }

        public async Task<List<IUser>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync<IUser>();
        }
    }
}
