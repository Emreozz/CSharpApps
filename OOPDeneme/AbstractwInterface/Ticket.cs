using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractwInterface
{
    public abstract class Ticket
    {
        public double Money { get; }
        public int TicketId { get; }
        public string Destination { get; }
        public double Duration { get; }
        public Ticket(double money, int ticketId, string destination, double duration):this(money,ticketId,duration)
        {
            this.Destination = destination;
            
        }
        public Ticket(double money,int ticketId,double duration)
        {
            this.Money = money;
            this.TicketId = ticketId;
            this.Duration = duration;
        }
        public  double MoneyPerUnit()
        {
            return this.Money/this.Duration;
        }
        
    }
}
