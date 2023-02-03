using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name,int age,bool male):base(name,age,male)
        {
            base.Name = name;
            base.Age = age;
            base.Male = male;
        }
        public override string MakeASound()
        {
            return "Hav hav";
        }
    }
}
