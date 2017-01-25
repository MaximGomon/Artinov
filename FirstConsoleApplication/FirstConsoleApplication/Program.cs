using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            //get int from user input
            //exception of wrong input data
            string [] myStringArray = new string[4];
            int[] myIntArray = new int[3];

            Console.WriteLine("Hello");

            DisplayArray(CreateAndFillArray(GetNumberFromUserInput()));

            //Ctrl+R+M - extract method (выносит выделеный код в новый метод)
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        //F2 || Ctrl+R+R => rename
        private static string[] CreateAndFillArray(int elementCount)
        {
            string[] userCreatedArray = new string[elementCount];

            for (int i = 0; i < elementCount; i++)
            {
                Console.Write("Please enter \'{0}\' element of array: ", i);
                userCreatedArray[i] = Console.ReadLine();
            }
            return userCreatedArray;
        }

        private static void DisplayArray(string[] userCreatedArray)
        {
            Console.WriteLine(new String('*', 20));
            Console.WriteLine("Array, that you already created:");

            for (int i = 0; i < userCreatedArray.Length; i++)
            {
                Console.WriteLine(userCreatedArray[i]);
            }

            Console.WriteLine(new String('*', 20));
        }

        private static int GetNumberFromUserInput()
        {
            int result = 0;
            bool isUserInputDigit = false;

            while (isUserInputDigit == false)//true
            {
                Console.Write("Please enter count of elements in array: ");
                string userInput = Console.ReadLine();

                isUserInputDigit = int.TryParse(userInput, out result);

                if (isUserInputDigit == true)
                {
                    Console.WriteLine("You input \'{0}\'", userInput);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!Please enter only digit!");
                    Console.ResetColor();
                }
            }
            return result;
        }
    }
}
