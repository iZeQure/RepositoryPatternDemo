using Demo.DbContexts;
using Demo.Models.User;
using Demo.Repositories.UserRepository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly XPowerDbContext _dbContext;

        public UserRepository(XPowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUser Create(IUser item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IUser item)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetAll()
        {
            return _dbContext.Users.ToList<IUser>();
        }

        public IUser GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IUser GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public IUser Update(IUser item)
        {
            throw new NotImplementedException();
        }
    }
}
