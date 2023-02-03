using CoreV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesV2.Concrete
{
    public class Customer :IEntity

    {
        public string CustomerID { get; set; }  
        public string ContactName { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
    }
}
