using Demo.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repositories.UserRepository.Abstractions
{
    public interface IUserRepository : IRepository<IUser, long>
    {
        IUser GetByUsername(string username);
    }
}
