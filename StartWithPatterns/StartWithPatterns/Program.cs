using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            #region Static property
            StaticObject item = new StaticObject();
            item.Name = "Test1";
            StaticObject.ObjectId = 4;

            Console.WriteLine(item);

            StaticObject item2 = new StaticObject();
            item2.Name = "Test2";
            Console.WriteLine(item2);
            #endregion

            SingletonObject element = SingletonManager.Instance;
            SingletonObject element2 = SingletonManager.Instance;

            bool isEqual = object.ReferenceEquals(element, element2);
            if(isEqual)
                Console.WriteLine("It`s two object are the same");

            Console.ReadLine();
        }
    }
}
