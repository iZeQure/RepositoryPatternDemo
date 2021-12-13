using Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Repositories
{
    public interface IEntityReader<T, K> where T : IAggregateRoot
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(K id);
    }
}
