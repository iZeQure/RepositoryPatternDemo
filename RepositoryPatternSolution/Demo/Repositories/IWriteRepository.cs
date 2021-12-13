using Demo.Models;

namespace Demo.Repositories
{
    public interface IWriteRepository<T> : IEntityCreater<T>, IEntityUpdater<T>, IEntityRemover<T> 
        where T : IAggregateRoot 
    { }
}
