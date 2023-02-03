using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Male { get; set; }
        public Animal(string name, int age, bool male)
        {
            Name = name;
            Age = age;
            Male = male;
        }

        public virtual string MakeASound()
        {
            return "Animal sounds like animal";
        }
    }
}
