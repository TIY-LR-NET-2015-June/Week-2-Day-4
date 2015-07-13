using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();

            var barks = dog.Bark(1);

            foreach (var bark in barks)
            {
                Console.WriteLine(bark);
            }

            Console.ReadKey();
        }
    }
}
