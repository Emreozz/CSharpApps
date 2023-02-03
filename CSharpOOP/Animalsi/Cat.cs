using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, bool male) : base(name, age, male)
        {
            this.Name = name;
            this.Age = age;
            this.Male = male;
        }

        public override string MakeASound()
        {
            return "Miyav miyav";
        }
    }
}
