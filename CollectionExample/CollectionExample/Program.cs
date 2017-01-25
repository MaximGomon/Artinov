using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Ctrl+R+M
            //WorkWithList();
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "first");
            myDictionary.Add(5, "second");
            myDictionary.Add(10, "some text");
            //DisplayIntStringDictionary(myDictionary);
            //Console.WriteLine(myDictionary[10]);

            IDictionary<int, string> test = new Dictionary<int, string>
            {
                {3, "value" },
                {98, "test" },
                {39, "item" }
            };
           // DisplayIntStringDictionary(test);

            IGeneric<IParent> collection = new Generic<IParent>();
            collection.Add(new Parent());
            collection.Add(new SomeClass());
            collection.Add(new Parent());

            //IGeneric<string> collectionStr = new Generic<string>();


            Console.WriteLine(collection);


            //List<IParent> par = new List<IParent>();
            //par.Add(new Parent());
            //par.Add(new SomeClass());

            //IParent parent = new Parent();
            //parent = new SomeClass();
            Console.ReadLine();
        }

        private static void DisplayIntStringDictionary(Dictionary<int, string> dictionary)
        {
            Console.WriteLine(new String('*', 15));
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} \t {item.Value}");
            }
            Console.WriteLine(new String('*', 15));
        }

        private static void WorkWithList()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(46);
            myList.Add(34);
            myList.Add(5);
            //LINQ
            //var firstElement = myList[0];
            //for (int i = 0; i < myList.Count; i++)
            //{

            //}
            //DisplayIntList(myList);
            //myList.RemoveAt(3);

            GetAndDisplayIndexOfItem(myList, 5);

            DisplayIntList(myList);
            myList.Sort();

            DisplayIntList(myList);

            if (myList.Contains(5) == true)
            {
                Console.WriteLine("MyList contains 5");
            }

            GetAndDisplayIndexOfItem(myList, 5);
            myList.Clear();
            DisplayIntList(myList);

            List<string> strings = new List<string>
            {
                "Hello",
                "Name",
                "Street"
            };

            DisplayStringList(strings);
            Console.ReadLine();
        }

        private static void GetAndDisplayIndexOfItem(List<int> myList, int item)
        {
            int indexOfFive = myList.IndexOf(item);
            Console.WriteLine($"Index of {item} in myList is {indexOfFive}");
        }

        private static void DisplayStringList(List<string> myList)
        {
            Console.WriteLine(new String('*', 5));
            foreach (string element in myList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new String('*', 5));
        }

        private static void DisplayIntList(List<int> myList)
        {
            Console.WriteLine(new String('*', 5));
            foreach (int element in myList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new String('*', 5));
        }
    }
}
