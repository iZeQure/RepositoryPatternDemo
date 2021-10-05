using Demo.Repositories;

namespace Demo.Models.User
{
    /// <summary>
    /// Represents a generic User.
    /// </summary>
    public interface IUser : IAggregateRoot
    {
        long Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string FullName { get; }
        string Username { get; }
    }
}
