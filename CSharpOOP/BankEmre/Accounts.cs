using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEmre
{
    internal abstract class Accounts:IBank
    {
        public string Customer { get; set; }
        public int Balance { get; set; }
        public int InterestRate { get; set; }
        public Accounts(string customer,int balance,int interestrate)
        {
            Customer = customer;
            Balance = balance;
            InterestRate = interestrate;
        }
        public abstract double CalculateInterestRate(); 
    }
}
