using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                UserTypes type = new UserTypes
                {
                    AccessToData = "SomeData",
                    TypeName = "Admin"
                };
                Users user = new Users
                {
                    FirstName = "Max",
                    LastName = "Gomon",
                    Login = "test",
                    UserTypes = type,
                    IsActiveStatus = true,
                    IsAllowAdultContent = true,
                    Password = "Pass",
                };
                using (var context = new TvAppDBaseEntities())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                Console.WriteLine("All good");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
