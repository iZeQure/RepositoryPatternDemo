using Demo.Models;

namespace Demo.Repositories
{
    public interface IRepository<T, K> : IReadOnlyRepository<T, K>, IWriteRepository<T> 
        where T : IAggregateRoot
    { }
}
