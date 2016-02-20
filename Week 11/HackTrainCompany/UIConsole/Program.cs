using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    using DataAccess;

    class Program
    {
        static void Main(string[] args)
        {
            UserSet user = new UserSet {Username = "admin",
                Email = "admin@admin.com",
                Address = "bul. mariqgoliza 1",
                 PasswordHash = PasswordHash.HashPassword("12345"),
                 CreditCardNumberHash = PasswordHash.HashPassword("111122223333"),
                 IsAdmin = true
            };
            //DataAccess.AddUser(user)
            // TODO : fix connection to db
            var sofia = new CitySet() { Name = "sofiq" };
            DataAccess.AddCity(sofia);
        }
    }
}
