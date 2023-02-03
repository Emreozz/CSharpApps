using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Worker : IHuman
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public double Wage { get; set; }    
        public double Hours { get; set; }

        public Worker(string firstName, string lastName, double wage, double hours)
        {
            FirstName = firstName;
            LastName = lastName;
            Wage = wage;
            Hours = hours;

            
        }

        public double CalculateHourlyWage()
        {
            return (this.Wage) / (this.Hours);
        }
    }
}
