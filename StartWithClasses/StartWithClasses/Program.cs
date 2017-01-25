using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animals animal = new Animals("Noname");
            //animal.Say();
            //Ctrl+K+C

            Birds bird = new Birds("Solovey");
            bird.Say();
            Mammal monkey = new Mammal("monkey");

            List<Animals> animals = new List<Animals>();
            animals.Add(bird);
            animals.Add(monkey);

            foreach (var animal in animals)
            {
                animal.Say();
            }

            //Console.WriteLine(bird);

            Console.ReadLine();
        }
    }
}
