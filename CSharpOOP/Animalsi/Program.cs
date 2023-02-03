using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Animal, string> list = new Dictionary<Animal, string>();
            Cat cat1 = new Cat("Tekir", 2, false);
            Dog dog1 = new Dog("Rex", 4, true);
            Frog frog1=new Frog("Zibidik",1,false);
            list.Add(cat1, cat1.MakeASound());
            list.Add(dog1, dog1.MakeASound());
            list.Add(frog1, frog1.MakeASound());
            string ar = cat1.Age.ToString();
            
            foreach(KeyValuePair<Animal, string> kvp in list)
            {
                Console.WriteLine("Name:{1} Age:{2} Male:{3}", kvp.Key.Name, kvp.Key.Age, kvp.Key.Male, kvp.Value);
            }
            Console.ReadLine();
            
        }
    }
}
