using AbstractwInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
         static void Main(string[] args)
         {
            //IAnimal newanimal = new Dog("Ceku", "Kedi",16);
            //newanimal.GiveMoreInfo();
            //newanimal.GiveInfo();

            Train train = new Train(200,2,5);
            train.MoneyPerUnit();
            Console.WriteLine(train.MoneyPerHour();
            Console.WriteLine(train.TicketId);
            Console.ReadLine();
         }
    }


}
