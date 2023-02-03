using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankEmre
{
    internal class DepositAccount : Accounts
    {
        private string HumanType { get; set; }
        public DepositAccount(string customer,int balance,int interesetrate): base(customer,balance,interesetrate)
        {

            HumanType = customer;
        }
        public override double CalculateInterestRate()
        {
            if (HumanType == "Individual"&&this.Balance>0&&this.Balance<1000)
            {
                this.InterestRate = 0;
                return this.number

            }
        }
    }
}
