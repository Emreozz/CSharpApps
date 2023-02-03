using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme
{
    internal class Dog : IAnimal
    {
        public string Name { get;}

        public string Kind {get;}

        public Dog(string name,string kind):this(kind)
        {
            Name = name;
            
        }
        public Dog(string kind)
        {
            Kind = kind;
        }
        public void GiveInfo()
        {
            Console.WriteLine(this.Name+"/"+this.Kind);
        }
    }
}
