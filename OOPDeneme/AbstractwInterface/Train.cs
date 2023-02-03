using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractwInterface
{
    public class Train : Ticket, IVehicle
    {
        public Train(double money, int ticketId, double duration) : base(money,ticketId,duration)
        {
        }
        
    }
}
