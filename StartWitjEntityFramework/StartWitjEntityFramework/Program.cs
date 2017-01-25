using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartWithEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                using (var context = new EfDbContext())
                {
                    //var people = context.Peoples.Select(x => x)
                    //    .ToDictionary(a =>a.Age, b => b.FirstName);

                    foreach (var item in context.Peoples.Include(x => x.Profession))
                    {
                        if (item.Profession != null)
                        {
                            Console.WriteLine(item.Profession.Name);
                        }
                    }
                }
                //
                Console.WriteLine("All good");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
