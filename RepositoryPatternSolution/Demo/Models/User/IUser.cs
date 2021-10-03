namespace Demo.Models.User
{
    /// <summary>
    /// Represents a generic User.
    /// </summary>
    public interface IUser
    {
        long Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string FullName { get; }
        string Username { get; }
    }
}
