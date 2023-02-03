using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalShelters<Dog> shelter = new AnimalShelters<Dog>();
            Console.WriteLine(shelter.animalList.Length);
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            Dog d = shelter.Release(1);
            Console.WriteLine(d);
            d = shelter.Release(0);
            Console.WriteLine(d);
            d = shelter.Release(0); // Release the third dog
            Console.WriteLine(d);
            d = shelter.Release(0);
            d = shelter.Release(0); // Release the third dog
            Console.WriteLine(d);
            d = shelter.Release(0);
            Console.ReadLine();
        }
    }
}
