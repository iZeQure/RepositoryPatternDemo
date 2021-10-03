using Demo.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Generators
{
    internal static class UserDataGenerator
    {
        internal static List<User> GenerateUsers()
        {
            return PopulatedDataSet();
        }

        private static List<User> PopulatedDataSet()
        {
            var dataSet = new List<User>
            {
                new User(1, "Bruce", "Floyd", "Pioch"),
                new User(2, "Delia", "Caldwell", "Gumh"),
                new User(3, "Lela", "Owen", "Dog"),
                new User(4, "Grady", "Howard", "Leoch"),
                new User(5, "George", "Wong", "Geonnchaa"),
                new User(6, "Glenda", "Beck", "Mubudh"),
                new User(7, "Verna", "Keller", "Caollud"),
                new User(8, "Alonzo", "Lewis", "Bailliam"),
                new User(9, "Mack", "Wilson", "Pirdornid"),
                new User(10, "Bethany", "Herrera", "Ageolriagh"),
            };

            return dataSet;
        }
    }
}
