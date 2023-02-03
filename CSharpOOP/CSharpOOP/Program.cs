using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Ali","Veli",8600,10);

            SortedList<Student,int> students_list = new SortedList<Student,int>();
            SortedList<Worker, int> workers_list = new SortedList<Worker, int>();

            students_list.Add(new Student("Emre","Ozturk",100),1);
            students_list.Add(new Student("Deniz", "Ozturk", 80),2);
            students_list.Add(new Student("Ali", "Veli", 40),3);
            students_list.Add(new Student("Emir", "Tas", 20),4);
            students_list.Add(new Student("Ahmet", "Cakil", 50),5);

            workers_list.Add(new Worker("Ali", "Veli", 8600, 10),1);
            workers_list.Add(new Worker("Ahmet", "Veli", 5000, 10),2);
            workers_list.Add(new Worker("Zeki", "Veli", 10000, 10),3);

            Console.WriteLine(worker1.CalculateHourlyWage());

            //foreach (KeyValuePair<Student, int> kvp in students_list)
            //{
            //    Console.WriteLine("{0}. student's mark is: {1} .", kvp.Value, kvp.Key.mark);
            //}

            foreach (KeyValuePair<Worker, int> kvp in workers_list)
            {
                Console.WriteLine("{0}. worker's wage is: {1} .", kvp.Value, kvp.Key.Wage);
            }

            Console.ReadLine();
        }
    }
}
