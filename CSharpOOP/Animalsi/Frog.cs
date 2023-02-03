using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Frog:Animal
    {
        public Frog(string name, int age, bool male) : base(name, age, male)
        {
            this.Name = name;
            this.Age = age;
            this.Male = male;
        }

        public override string MakeASound()
        {
           return "quvak quvak";
        }
    }
}
