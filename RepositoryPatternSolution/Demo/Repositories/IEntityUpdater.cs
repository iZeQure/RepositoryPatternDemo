using Demo.Models;
using System.Threading.Tasks;

namespace Demo.Repositories
{
    public interface IEntityUpdater<T> where T : IAggregateRoot
    {
        public Task<T> UpdateAsync(T entity);
    }
}
