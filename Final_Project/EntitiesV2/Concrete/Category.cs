using CoreV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesV2.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }    
    }
}
