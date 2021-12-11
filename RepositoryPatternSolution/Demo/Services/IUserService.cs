using Demo.Models.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IUserService
    {
        public Task<List<IUser>> GetUsersAsync();

        public Task<IUser> GetUserById(long id);
    }
}
