using Demo.Models;
using System.Threading.Tasks;

namespace Demo.Repositories
{
    public interface IEntityRemover<T> where T : IAggregateRoot
    {
        public Task<bool> RemoveAsync(T entity);
    }
}
