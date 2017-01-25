using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            using (var client = new CalcServiceClient())
            {
                client.Open();
                Console.WriteLine(client.Sum(4, 5));
                Console.WriteLine(client.Devide(4, 5));

                client.Close();
            }
            Console.ReadLine();
        }
    }
}
