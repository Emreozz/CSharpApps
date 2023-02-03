using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog:IAnimal
    {
        public string Name { get; }

        public string Kind { get; }

        public int Age { get; set; }
        public Dog(string name, string kind,int age) : this(kind)
        {
            Name = name;
            Age = age;
        }
        public Dog(string kind)
        {
            Kind = kind;
            
        }
        public void GiveInfo()
        {
            Console.WriteLine(this.Name + "/" + this.Kind);
        }

        public void GiveMoreInfo()
        {
            throw new NotImplementedException();
        }
    }
}
