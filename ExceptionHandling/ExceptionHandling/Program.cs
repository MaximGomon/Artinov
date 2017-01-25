using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                DoSomething();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("It`s not implemented exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.ReadLine();
        }

        private static void DoSomething()
        {
            Console.WriteLine("Do");
            //ThrowException();
            ThrowNewException();
        }

        private static void CreateException()
        {
            throw new NotImplementedException();
        }

        private static void ThrowException()
        {
            try
            {
                CreateException();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static void ThrowNewException()
        {
            try
            {
                dynamic d = 4;
                string i = d;
                File.WriteAllText("T:", "");
                //CreateException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
