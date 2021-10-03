using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
