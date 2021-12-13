using Demo.Models;

namespace Demo.Repositories
{
    public interface IReadOnlyRepository<T, K> : IEntityReader<T, K>
        where T : IAggregateRoot 
    { }
}
