using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.User
{
    /// <summary>
    /// Respresents a concrete User.
    /// </summary>
    public class User : IUser
    {
        /// <summary>
        /// <br>The Internal contructor is good when we don't want the client to create the instance.</br>
        /// <br>We would usually want to do it if we want to control how the instance should be created.</br>
        /// </summary>
        internal User() { }

        /// <summary>
        /// Initializes a new <see cref="User"/>.
        /// </summary>
        /// <param name="id">Represent the identify of the user.</param>
        /// <param name="firstName">A name that desribes the user's first name.</param>
        /// <param name="lastName">A name that desribes the user's last name.</param>
        /// <param name="username">Describes the user with a generic username.</param>
        public User(long id, string firstName, string lastName, string username)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
        }

        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string Username { get; set; }
    }
}
