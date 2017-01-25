using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] userArray = new string[2,3];
            for (int rowNumber = 0; rowNumber < userArray.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < userArray.GetLength(1); columnNumber++)
                {
                    Console.Write("Please enter \'{0}, {1}\' element ", rowNumber, columnNumber);
                    userArray[rowNumber, columnNumber] = Console.ReadLine();
                }
            }

            Console.WriteLine();
            
            for (int rowNumber = 0; rowNumber < userArray.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < userArray.GetLength(1); columnNumber++)
                {
                    Console.Write(userArray[rowNumber, columnNumber] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            //stamina
        }
    }
}
