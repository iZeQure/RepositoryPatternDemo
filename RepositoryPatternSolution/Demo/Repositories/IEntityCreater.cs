using Demo.Models;
using System.Threading.Tasks;

namespace Demo.Repositories
{
    public interface IEntityCreater<T> where T : IAggregateRoot
    {
        public Task<T> CreateAsync(T entity);
    }
}
